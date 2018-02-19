using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class movimientoproductoaccion
    {
        public valedetalle valedet { get; set; }
        public List<serie> listaserie { get; set; }
        public movimientoproductoaccion()
        {
            this.valedet = null;
            this.listaserie = null;
        }
    }
}
