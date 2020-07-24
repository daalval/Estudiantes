using Logica;
using Logica.Libreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes
{
    public partial class Form1 : Form
    {
        private LEstudiantes estudiante;
        //private Librerias librerias;
        public Form1()
        {
            InitializeComponent();

            //librerias = new Librerias();

            var listTextBox = new List<TextBox>();
            listTextBox.Add(textBoxDNI);
            listTextBox.Add(textBoxNombre);
            listTextBox.Add(textBoxApellido);
            listTextBox.Add(textBoxEmail);

            var listLabel = new List<Label>();
            listLabel.Add(labelDNI);
            listLabel.Add(labelNombre);
            listLabel.Add(labelApellido);
            listLabel.Add(labelEmail);
            listLabel.Add(labelPaginas);

            Object[] objetos = { 
                pictureBoxImage,
                Properties.Resources.baseline_person_black_48dp,
                dataGridViewEstudiantes,
                numericUpDownRegistros
            };

            estudiante = new LEstudiantes(listTextBox, listLabel, objetos);
        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            estudiante.uploadImage.cargarImagen(pictureBoxImage);
        }

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDNI.Text.Equals(""))
            {
                labelDNI.ForeColor = Color.Red;
            }
            else
            {
                labelDNI.ForeColor = Color.LightGreen;
                labelDNI.Text = "DNI";
            }
        }

        private void textBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNombre.Text.Equals(""))
            {
                labelNombre.ForeColor = Color.Red;
            }
            else
            {
                labelNombre.ForeColor = Color.LightGreen;
                labelNombre.Text = "Nombre";
            }
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.textKeyPress(e);
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            if (textBoxApellido.Text.Equals(""))
            {
                labelApellido.ForeColor = Color.Red;
            }
            else
            {
                labelApellido.ForeColor = Color.LightGreen;
                labelApellido.Text = "Apellido";
            }
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Equals(""))
            {
                labelEmail.ForeColor = Color.Red;
            }
            else
            {
                labelEmail.ForeColor = Color.LightGreen;
                labelEmail.Text = "Email";
            }
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void buttonAnyadir_Click(object sender, EventArgs e)
        {
            estudiante.registrar();
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            estudiante.buscarEstudiante(textBoxBuscar.Text);
        }

        private void buttonPrimero_Click(object sender, EventArgs e)
        {
            estudiante.paginador("Primero");
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            estudiante.paginador("Anterior");
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            estudiante.paginador("Siguiente");
        }

        private void buttonUltimo_Click(object sender, EventArgs e)
        {
            estudiante.paginador("Ultimo");
        }

        private void numericUpDownRegistros_ValueChanged(object sender, EventArgs e)
        {
            estudiante.registroPaginas();
        }

        private void dataGridViewEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEstudiantes.Rows.Count != 0)
            {
                estudiante.getEstudiante();
            }
        }

        private void dataGridViewEstudiantes_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridViewEstudiantes.Rows.Count != 0)
            {
                estudiante.getEstudiante();
            }
        }
    }
}
