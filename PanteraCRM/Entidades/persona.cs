using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class persona
    {
        public int p_inidpersona { get; set; }
        public string nrodocumento { get; set; }
        public string chapellidopaterno { get; set; }
        public string chapellidomaterno { get; set; }
        public string chnombres { get; set; }
        public string chfechanacimiento { get; set; }
        public int p_inidtiposexo { get; set; }
        public string chtelefono { get; set; }
        public string chdireccion { get; set; }
        public string observacion { get; set; }
        public bool estado { get; set; }
        public int p_inidubigeo { get; set; }
        public int p_inidtipodocumento { get; set; }
        public persona()
        {
            this.p_inidpersona = 0;
            this.nrodocumento = string.Empty;
            this.chapellidopaterno = string.Empty;
            this.chapellidomaterno = string.Empty;
            this.chnombres = string.Empty;
            this.chfechanacimiento = string.Empty;
            this.p_inidtiposexo = 0;
            this.chtelefono = string.Empty;
            this.chdireccion = string.Empty;
            this.observacion = string.Empty;
            this.estado = false;
            this.p_inidubigeo = 0;
            this.p_inidtipodocumento = 0;
        }
    }
}
