﻿using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public abstract class impresoraNE
    {
        public static string buscarPornombrepc()
        {
            return impresoraDL.buscarPornombrepc(System.Environment.MachineName);
        }
    }
}
