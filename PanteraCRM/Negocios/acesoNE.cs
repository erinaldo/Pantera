using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocios
{
    public abstract class acesoNE
    {
        //BUSQUEDA DE USUARIO POR LOGIN Y CLAVE
        public static sessionglobal buscarAcesoPorLoginClaveNE(string login, string clave)
        {
            try
            {
                if (login == string.Empty || login.Trim().Length == 0)
                {
                    throw new Exception("Ingrese un Usuario");
                }
                if (clave == string.Empty || clave.Trim().Length == 0)
                {
                    throw new Exception("Ingrese su Clave ");
                }
                return acesoDL.buscarAcesoPorLoginClaveDL(login, clave);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
