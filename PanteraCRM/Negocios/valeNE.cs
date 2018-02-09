using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocios
{
    public abstract class valeNE
    {
        public static List<valecabecera> valesListar()
        {
            return valesDL.valesListar();
        }
        public static int generarcorrelativo()
        {
            return valesDL.generarCorelativoIngresar();
        }
    }
}
