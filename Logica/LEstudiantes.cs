using Datos;
using LinqToDB;
using Logica.Libreria;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class LEstudiantes : Librerias
    {
        private List<TextBox> listTextBox;
        private List<Label> listLabel;
        private PictureBox imagen;
        private Bitmap _imagBitmap;
        private DataGridView _dataGridView;
        private NumericUpDown _numericUpDown;
        private Paginador<Estudiante> _paginador;
        private string _accion = "insert";
        //private Librerias librerias;
        public LEstudiantes(List<TextBox> listTextBox, List<Label> listLabel, object[] objetos)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            //librerias = new Librerias();
            imagen = (PictureBox)objetos[0];
            _imagBitmap = (Bitmap)objetos[1];
            _dataGridView = (DataGridView)objetos[2];
            _numericUpDown = (NumericUpDown)objetos[3];

            reestablecerCampos();
        }

        public void registrar()
        {
            if (listTextBox[0].Text.Equals(""))
            {
                listLabel[0].Text = "Este campo es obligatorio";
                listLabel[0].ForeColor = Color.Red;
                listTextBox[0].Focus();
            }
            else if (listTextBox[1].Text.Equals(""))
            {
                listLabel[1].Text = "Este campo es obligatorio";
                listLabel[1].ForeColor = Color.Red;
                listTextBox[1].Focus();
            }
            else if (listTextBox[2].Text.Equals(""))
            {
                listLabel[2].Text = "Este campo es obligatorio";
                listLabel[2].ForeColor = Color.Red;
                listTextBox[2].Focus();
            }
            else if (listTextBox[3].Text.Equals(""))
            {
                listLabel[3].Text = "Este campo es obligatorio";
                listLabel[3].ForeColor = Color.Red;
                listTextBox[3].Focus();
            }
            else
            {
                if (textBoxEvent.comprobarFormatoEmail(listTextBox[3].Text))
                {
                    var usuario = _estudiante.Where(u => u.email.Equals(listTextBox[3].Text)).ToList();
                    if (usuario.Count.Equals(0))
                    {
                        guardarUsuario();
                    }
                    else
                    {
                        if (usuario[0].id.Equals(_idEstudiante))
                        {
                            guardarUsuario();
                        }
                        else
                        {
                            listLabel[3].Text = "Email ya registrado";
                            listLabel[3].ForeColor = Color.Red;
                            listTextBox[3].Focus();
                        }
                    }
                }
                else
                {
                    listLabel[3].Text = "Email no válido";
                    listLabel[3].ForeColor = Color.Red;
                    listTextBox[3].Focus();
                }
            }
        }
        private void guardarUsuario()
        {
            BeginTransactionAsync();
            try
            {
                var imageArray = uploadImage.imageToByte(imagen.Image);

                switch (_accion)
                {
                    case "insert":
                        _estudiante.Value(e => e.dni, listTextBox[0].Text)
                            .Value(e => e.nombre, listTextBox[1].Text)
                            .Value(e => e.apellido, listTextBox[2].Text)
                            .Value(e => e.email, listTextBox[3].Text)
                            .Value(e => e.imagen, imageArray)
                            .Insert();
                        break;
                    case "update":
                        _estudiante.Where(u => u.id.Equals(_idEstudiante))
                            .Set(e => e.dni, listTextBox[0].Text)
                            .Set(e => e.nombre, listTextBox[1].Text)
                            .Set(e => e.apellido, listTextBox[2].Text)
                            .Set(e => e.email, listTextBox[3].Text)
                            .Set(e => e.imagen, imageArray)
                            .Update();
                        break;
                }

                CommitTransaction();

                reestablecerCampos();
            }
            catch (Exception)
            {
                RollbackTransaction();
            }
        }

        private int _reg_por_pagina = 2;
        private int _num_pagina = 1;
        public void buscarEstudiante(string campoBuscar)
        {
            List<Estudiante> consulta = new List<Estudiante>();
            int inicio = (_num_pagina - 1) * _reg_por_pagina;

            if (campoBuscar.Equals(""))
            {
                consulta = _estudiante.ToList();
            }
            else
            {
                consulta = _estudiante.Where(c => c.dni.StartsWith(campoBuscar) || c.nombre.StartsWith(campoBuscar)
                || c.apellido.StartsWith(campoBuscar)).ToList();
            }

            if (consulta.Count > 0)
            {
                _dataGridView.DataSource = consulta.Select(c => new { 
                    c.id,
                    c.dni,
                    c.nombre,
                    c.apellido,
                    c.email,
                    c.imagen
                }).Skip(inicio).Take(_reg_por_pagina).ToList();

                _dataGridView.Columns[0].Visible = false;
                _dataGridView.Columns[5].Visible = false;
                _dataGridView.Columns[1].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                _dataGridView.Columns[3].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
            else
            {
                _dataGridView.DataSource = consulta.Select(c => new {
                    c.dni,
                    c.nombre,
                    c.apellido,
                    c.email
                }).ToList();
            }
        }
        private int _idEstudiante = 0;
        public void getEstudiante()
        {
            _accion = "update";
            _idEstudiante = Convert.ToInt32(_dataGridView.CurrentRow.Cells[0].Value);
            listTextBox[0].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[1].Value);
            listTextBox[1].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[2].Value);
            listTextBox[2].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[3].Value);
            listTextBox[3].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[4].Value);

            try
            {
                byte[] arrayImage = (byte[])_dataGridView.CurrentRow.Cells[5].Value;
                imagen.Image = uploadImage.byteArrayToImage(arrayImage);
            }
            catch (Exception)
            {
                imagen.Image = _imagBitmap;
            }
        }
        private List<Estudiante> listEstudiante;
        public void paginador(String metodo)
        {
            switch (metodo)
            {
                case "Primero":
                    _num_pagina = _paginador.primeraPagina();
                    break;
                case "Anterior":
                    _num_pagina = _paginador.anteriorPagina();
                    break;
                case "Siguiente":
                    _num_pagina = _paginador.siguientePagina();
                    break;
                case "Ultimo":
                    _num_pagina = _paginador.ultimaPagina();
                    break;
            }
            buscarEstudiante("");
        }
        public void registroPaginas()
        {
            _num_pagina = 1;
            _reg_por_pagina = (int)_numericUpDown.Value;
            var list = _estudiante.ToList();

            if (list.Count > 0)
            {
                _paginador = new Paginador<Estudiante>(listEstudiante, listLabel[4], _reg_por_pagina);
                buscarEstudiante("");
            }
        }
        private void reestablecerCampos()
        {
            _accion = "insert";
            _num_pagina = 1;
            _idEstudiante = 0;
            imagen.Image = _imagBitmap;
            listLabel[0].Text = "DNI";
            listLabel[1].Text = "Nombre";
            listLabel[2].Text = "Apellido";
            listLabel[3].Text = "E-mail";
            listLabel[0].ForeColor = Color.Black;
            listLabel[1].ForeColor = Color.Black;
            listLabel[2].ForeColor = Color.Black;
            listLabel[3].ForeColor = Color.Black;
            listTextBox[0].Text = "";
            listTextBox[1].Text = "";
            listTextBox[2].Text = "";
            listTextBox[3].Text = "";
            listEstudiante = _estudiante.ToList();

            if (listEstudiante.Count > 0)
            {
                _paginador = new Paginador<Estudiante>(listEstudiante, listLabel[4], _reg_por_pagina);
            }

            buscarEstudiante("");
        }
    }
}
