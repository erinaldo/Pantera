﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class empresasesion
    {
        public int idempresa { get; set; }
        public string codigoempresa { get; set; }
        public string nombreempresa { get; set; }
        public string rucempresa { get; set; }
        public string direccion { get; set; }
        public string distrito { get; set; }
        public string telefono { get; set; }
        public empresasesion()
        {
            this.idempresa = 0;
            this.codigoempresa = string.Empty;
            this.nombreempresa = string.Empty;
            this.rucempresa = string.Empty;
            this.direccion = string.Empty;
            this.distrito = string.Empty;
            this.telefono = string.Empty;
        }
    }
}