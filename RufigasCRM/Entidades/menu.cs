using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Entidades
{
    public class menu
    {
        [JsonProperty("p_inidmenu")]
        public int idmenu { get; set; }

        [JsonProperty("chcodigomenu")]
        public int codigomenu { get; set; }
        [JsonProperty("chdescripcionmenu")]
        public string descripcion { get; set; }
        [JsonProperty("chiconomenu")]
        public string icono { get; set; }
        [JsonProperty("inorden")]
        public int orden { get; set; }
        [JsonProperty("chinstancia")]
        public string instancia { get; set; }

        [JsonProperty("submenu")]
        public List<menu> submenu { get; set; }

        public menu()
        {
            this.idmenu = 0;
            this.codigomenu = 0;
            this.descripcion = string.Empty;
            this.icono = string.Empty;
            this.orden = 0;
            this.instancia = string.Empty;
            this.submenu = new List<menu>();
        }
    }
}
