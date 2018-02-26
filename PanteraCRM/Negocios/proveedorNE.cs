using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocios
{
    public abstract class proveedorNE
    {
        public static List<proveedor> proveedorListar()
        {
            return proveedorDL.proveedorListar();
        }
        public static int ProveedorIngresar(proveedores registros)
        {
            return proveedorDL.ProveedorIngresar(registros);
        }
        public static proveedor ProveedorBusquedaRuc(string ruc)
        {
            return proveedorDL.ProveedorBusquedaRuc(ruc);
        }
        public static List<proveedor> ProveedorBusquedaParametro(string parametro)
        {
            return proveedorDL.ProveedorBusquedaParametro(parametro);
        }
        public static string ProveedorBusquedaCodigo(int codigo)
        {
            return proveedorDL.BuscarProveedorPorCodigo(codigo);
        }

    }
}
