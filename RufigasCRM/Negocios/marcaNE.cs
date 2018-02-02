using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public abstract class marcaNE
    {
        public static List<marca> marcaListar()
        {
            return marcaDL.marcaListar();
        }
        public static int marcaInsertar(marca marca)
        {
            return marcaDL.marcaInsertar(marca);
        }
        public static string marcaObtenerNumero()
        {
            return marcaDL.obtenerNumero();
        }
        public static int marcaActualizar(marca marca)
        {
            return marcaDL.marcaActualizar(marca);
        }

    }
}
