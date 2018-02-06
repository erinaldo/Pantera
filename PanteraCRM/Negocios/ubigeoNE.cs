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

        public static ubigeo buscarPorCodigo(string cod_ubigeo)
        {
            try
            {
                //if (cod_ubigeo == string.Empty || cod_ubigeo.Trim().Length == 0)
                //{
                //    throw new Exception("Ingrese un Ubigeo ");
                //}
                //if (cod_ubigeo.Trim().Length != 6)
                //{
                //    throw new Exception("Ingrese un Ubigeo de 6 dígitos");
                //}
                return ubigeoDL.buscarPorCodigo(cod_ubigeo);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<ubigeo> buscarPorDistrito(string desc_distrito)
        {
            try
            {
                if (desc_distrito == string.Empty || desc_distrito.Trim().Length == 0)
                {
                    throw new Exception("Ingrese un Ubigeo ");
                }
                return ubigeoDL.buscarPorDistrito(desc_distrito);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<ubigeo> ubigeoListar()
        {
            return ubigeoDL.ubigeoListar();
        }
    }
}
