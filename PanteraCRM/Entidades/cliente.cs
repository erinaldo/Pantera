﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class cliente
    {
        public int p_inidcodigoclie {get;set; }
        public string razon { get; set; }
        public string tipodocu { get; set; }
        public string nrodocumento { get; set; }
        public string chdireccion { get; set; }
        public string tipoclie { get; set; }
        public string telefono { get; set; }
        public string chcodigo { get; set; }
        public cliente()
        {
        this.p_inidcodigoclie = 0;
            this.razon = string.Empty;
            this.tipodocu = string.Empty;
            this.nrodocumento = string.Empty;
            this.chdireccion = string.Empty;
            this.tipoclie = string.Empty;
            this.telefono = string.Empty;
            this.chcodigo = string.Empty;

    }
}
    
}
