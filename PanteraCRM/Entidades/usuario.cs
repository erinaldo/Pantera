﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class usuario
    {
        public int p_inidusuario { get; set; }
        public int p_inidpersona { get; set; }
        public int p_inidpuntoventa { get; set; }
        public string chclave { get; set; }
        public bool estado { get; set; }
        public int p_inidperfil { get; set; }
        public string chusuario { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public usuario()
        {
            this.p_inidusuario = 0;
            this.p_inidpersona = 0;
            this.p_inidpuntoventa = 0;
            this.chclave = string.Empty;
            this.estado = false;
            this.p_inidperfil = 0;
            this.chusuario = string.Empty;
            this.nombre = string.Empty;
            this.descripcion = string.Empty;
    }
    }
}
