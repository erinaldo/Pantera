﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class proveedor
    {
        public string chcodigoproveedor { get; set; }
        public int p_inidcodigoclie { get; set; }
        public string razon { get; set; }
        public string tipodocu { get; set; }
        public string nrodocumento { get; set; }
        public string chdireccion { get; set; }
        public string tipoclie { get; set; }
        public string telefono { get; set; }
        public proveedor()
        {
            this.p_inidcodigoclie = 0;
            this.razon = string.Empty;
            this.nrodocumento = string.Empty;
            this.chdireccion = string.Empty;
            this.chdireccion = string.Empty;
            this.tipoclie = string.Empty;
            this.telefono = string.Empty;
            this.chcodigoproveedor = string.Empty;

    }
    }
}
