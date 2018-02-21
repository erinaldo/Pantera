using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public abstract class ubigeoNE
    {

        public static ubigeo buscarPorCodigo(int cod_ubigeo)
        {
           
                return ubigeoDL.buscarPorCodigo(cod_ubigeo);
            
        }
        public static List<ubigeo> BuscarPorParametro(string parametro)
        {
                return ubigeoDL.BuscarPorParametro(parametro);
           
        }
        public static List<ubigeo> ubigeoListar()
        {
            return ubigeoDL.ubigeoListar();
        }
    }
}
