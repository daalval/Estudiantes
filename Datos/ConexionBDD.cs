using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ConexionBDD : DataConnection
    {
        public ConexionBDD() : base("DAV2")
        {

        }
        public ITable<Estudiante> _estudiante
        {
            get
            {
                return GetTable<Estudiante>();
            }
        }
    }
}
