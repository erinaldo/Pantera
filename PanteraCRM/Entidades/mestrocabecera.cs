using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class maestrocabecera
    {
          public int p_inidmaestrocabecera { get; set; }
          public string chdesmoestro { get; set; }
          public string chobserbacion { get; set; }
          public bool estado { get; set; }
          public string chcodigomaestrocab { get; set; }
          public int p_inidusuarioinsert { get; set; }
          public int p_inidusuariodelete { get; set; }
        public maestrocabecera()
        {
            this.p_inidmaestrocabecera = 0;
            this.chdesmoestro = string.Empty;
            this.chobserbacion = string.Empty;
            this.estado = false;
            this.chcodigomaestrocab = string.Empty;
            this.p_inidusuarioinsert = 0;
            this.p_inidusuariodelete = 0;
    }
    }
}
