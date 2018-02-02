using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class parametro
    {
        public string key { get; set; }
        public object value { get; set; }

        public parametro()
        {
            this.key = null;
            this.value = null;
        }

        public parametro(string key, object value)
        {
            this.key = key;
            this.value = value;
        }
    }
}