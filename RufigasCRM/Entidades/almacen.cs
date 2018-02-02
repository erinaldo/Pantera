using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class almacen
    {
        public int idalmacen { get; set; }
        public int idempresa { get; set; }
        public string codigoalmacen { get; set; }
        public string nombrealmacen { get; set; }
        public string direccion { get; set; }
        public string ubigeo { get; set; }
        public int prefijoingreso { get; set; }
        public int numeroingreso { get; set; }
        public int prefijosalida { get; set; }
        public int numerosalida { get; set; }
        public string situacionalmacen { get; set; }
        public bool estadoalmacen { get; set; }
        public almacen()
        {
            this.idalmacen = 0;
            this.idempresa = 0;
            this.codigoalmacen = string.Empty;
            this.nombrealmacen = string.Empty;
            this.direccion = string.Empty;
            this.ubigeo = string.Empty;
            this.prefijoingreso = 0;
            this.numeroingreso = 0;
            this.prefijosalida = 0;
            this.numerosalida = 0;
            this.situacionalmacen = string.Empty;
            this.estadoalmacen = true;
        }
    }
}