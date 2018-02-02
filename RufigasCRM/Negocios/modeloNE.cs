using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public abstract class modeloNE
    {
        public static List<modelo> modeloListar()
        {
            return modeloDL.modeloListar();
        }
        public static List<modelo> modeloBuscarPorMarca(int idmarca)
        {
            return modeloDL.buscarPorMarca(idmarca);
        }
        public static int modeloInsertar(modelo modelo)
        {
            return modeloDL.modeloInsertar(modelo);
        }
        public static int modeloActualizar(modelo modelo)
        {
            return modeloDL.modeloActualizar(modelo);
        }
        public static string modeloObtenerNumero()
        {
            return modeloDL.obtenerNumero();
        }
    }
}
