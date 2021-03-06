﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public abstract class sesion
    { 
        public static usuariosesion usuariosesion { get; set; }
        public static empresasesion empresasesion { get; set; }
        public static almacensesion almacensesion { get; set; }
        public static puntoventasesion puntoventasesion { get; set; }
        public static string impresoraticket { get; set; }
        public static sessionglobal SessionGlobal { get; set; }
        public static List<serie> listaserie { get; set; }
        public static valedetalle valedetalles { get; set; }
        public static List<movimientoproductoaccion> movprodaccion { get; set; }
        public static List<pedidodetallecontenido> pedidodetallecontenido { get; set; }
    }
}
