using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;

namespace Datos
{
    public abstract class proveedorjuridicoDL
    {
        public static int ProveedorJuridicoIngresar(proveedorjuridico registros)
        {
            return conexion.executeScalar("fn_proveedorjuridico_ingresar",
            CommandType.StoredProcedure,
            new parametro("in_p_inidempresa", registros.p_inidempresa),
            new parametro("in_p_inidproveedor", registros.p_inidproveedor)
            );

        }
    }
}
