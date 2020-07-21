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
        private PictureBox image;
        //private Librerias librerias;
        public LEstudiantes(List<TextBox> listTextBox, List<Label> listLabel, object[] objetos)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            //librerias = new Librerias();
            image = (PictureBox)objetos[0];
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
                        listLabel[3].Text = "Email ya registrado";
                        listLabel[3].ForeColor = Color.Red;
                        listTextBox[3].Focus();
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
                var imageArray = uploadImage.imageToByte(image.Image);

                _estudiante.Value(e => e.dni, listTextBox[0].Text)
                    .Value(e => e.nombre, listTextBox[1].Text)
                    .Value(e => e.apellido, listTextBox[2].Text)
                    .Value(e => e.email, listTextBox[3].Text)
                    .Value(e => e.imagen, imageArray)
                    .Insert();

                CommitTransaction();
            }
            catch (Exception)
            {
                RollbackTransaction();
            }
        }
    }
}
