using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class impresoraDL
    {
        public static string buscarPornombrepc(string nombrepc)
        {
            return conexion.executeScalarStr("fn_impresora_buscar_por_nombrepc", CommandType.StoredProcedure, new parametro("in_nombrepc", nombrepc));
        }
         
    }
}
