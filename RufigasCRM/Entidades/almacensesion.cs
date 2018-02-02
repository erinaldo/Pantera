using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class almacensesion
    {
        public int idalmacen { get; set; }
        public string codigoalmacen { get; set; }
        public string nombrealmacen { get; set; }
        public string direccion { get; set; }
        public string ubigeo { get; set; }
        public almacensesion()
        {
            this.idalmacen = 0;
            this.codigoalmacen = string.Empty;
            this.nombrealmacen = string.Empty;
            this.direccion = string.Empty;
            this.ubigeo = string.Empty;
        }
    }
}