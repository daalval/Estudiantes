using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Libreria
{
    public class Paginador<T>
    {
        private List<T> _dataList;
        private Label _label;
        private static int maxReg, _reg_por_pagina, pageCount, numPag = 1;

        public Paginador(List<T> dataList, Label label, int reg_por_pagina)
        {
            _dataList = dataList;
            _label = label;
            _reg_por_pagina = reg_por_pagina;

            cargarDatos();
        }
        private void cargarDatos()
        {
            numPag = 1;
            maxReg = _dataList.Count;
            pageCount = (maxReg / _reg_por_pagina);
            //Ajusta el número de la página si la última página contiene una parte de la página
            if ((maxReg % _reg_por_pagina) > 0)
            {
                pageCount += 1;
            }

            _label.Text = $"Página 1/{pageCount}";
        }
        public int primeraPagina()
        {
            numPag = 1;
            _label.Text = $"Página {numPag}/{pageCount}";
            return numPag;
        }
        public int anteriorPagina()
        {
            if (numPag > 1)
            {
                numPag -= 1;
                _label.Text = $"Página {numPag}/{pageCount}";
            }
            return numPag;
        }
        public int siguientePagina()
        {
            if (numPag == pageCount)
            {
                numPag -= 1;
            }

            if (numPag < pageCount)
            {
                numPag += 1;
                _label.Text = $"Página {numPag}/{pageCount}";
            }
            return numPag;
        }
        public int ultimaPagina()
        {
            numPag = pageCount;
            _label.Text = $"Página {numPag}/{pageCount}";
            return numPag;
        }
    }
}
