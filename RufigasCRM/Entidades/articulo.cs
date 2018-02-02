using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class articulo
    {
        public int idarticulo { get; set; }
        public string codigoarticulo { get; set; }
        public string nombrearticulo { get; set; }
        public string idtipoarticulo { get; set; }
        public string tipoarticulo { get; set; }
        public string idcatearticulo { get; set; }
        public string catearticulo { get; set; }
        public string idmediarticulo { get; set; }
        public string fechacreacion { get; set; }
        public decimal precio { get; set; }
        public int idusuario { get; set; }
        public string idsituarticulo { get; set; }
        public bool estadoarticulo { get; set; }

        public articulo()
        {
            this.idarticulo = 0;
            this.codigoarticulo = string.Empty;
            this.nombrearticulo = string.Empty;
            this.idtipoarticulo = string.Empty;
            this.tipoarticulo = string.Empty;
            this.idcatearticulo = string.Empty;
            this.catearticulo = string.Empty;
            this.idmediarticulo = string.Empty;
            this.fechacreacion = string.Empty;
            this.precio = 0;
            this.idusuario = 0;
            this.idsituarticulo = string.Empty;
            this.estadoarticulo = true;
        }
    }
}
