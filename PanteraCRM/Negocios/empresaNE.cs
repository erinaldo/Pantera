using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public abstract class empresaNE
    {
        public static List<empresa> empresaListar()
        {
            return empresaDL.empresaListar();
        }
        public static empresasesion buscarPorCodigo(int idempresa)
        {
            try
            {
                return empresaDL.buscarPorCodigo(idempresa);
            }

            catch (Exception)
            {
                throw;
            }
        }
        public static int empresaInsertar(empresa empresa)
        {
            return empresaDL.empresaInsertar(empresa);
        }
        public static int empresaActualizar(empresa empresa)
        {
            return empresaDL.empresaActualizar(empresa);
        }
        public static int EmpresaIngresar(empresas registros)
        {
            return empresaDL.EmpresaIngresar(registros);
        }
        public static int EmpresaModificar(empresas registros)
        {
            return empresaDL.EmpresaModificar(registros);
        }
        public static empresas EmpresaBusquedaCodigo(int codigo)
        {
            return empresaDL.EmpresaBusquedaCodigo(codigo);
        }
    }
}