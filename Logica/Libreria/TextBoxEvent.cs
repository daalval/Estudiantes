﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Libreria
{
    public class TextBoxEvent
    {
        public void textKeyPress(KeyPressEventArgs e)
        {
            //Condición que solo nos permite ingresar datos de tipo texto
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //Condición que permite no dar salto de línea cuando se pulsa Enter
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }
            //Condición que nos permite utilizar la tecla de borrar
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //Condición que nos permite utilizar la tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public bool comprobarFormatoEmail(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }
    }
}
