using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Libreria
{
    public class Librerias : ConexionBDD
    {
        public UploadImage uploadImage = new UploadImage();
        public TextBoxEvent textBoxEvent = new TextBoxEvent();
    }
}
