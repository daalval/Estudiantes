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
        public LEstudiantes(List<TextBox> listTextBox, List<Label> listLabel, object[] objetos)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
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
                    var imageArray = uploadImage.imageToByte(image.Image);
                }
                else
                {
                    listLabel[3].Text = "Email no válido";
                    listLabel[3].ForeColor = Color.Red;
                    listTextBox[3].Focus();
                }
            }
        }
    }
}
