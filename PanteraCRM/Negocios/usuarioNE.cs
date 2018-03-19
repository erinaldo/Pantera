using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocios
{
    public abstract class usuarioNE
    {
        public static usuario buscarPorLoginClave(string login, string clave)
        {
            try
            {
                if (login == string.Empty || login.Trim().Length == 0)
                {
                    throw new Exception("Ingrese un login ");
                }
                if (clave == string.Empty || clave.Trim().Length == 0)
                {
                    throw new Exception("Ingrese una clave ");
                }
                return usuarioDL.buscarPorLoginClave(login, clave);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static usuario buscarPorCodigo(int idusuario)
        {
            return usuarioDL.buscarPorCodigo(idusuario);
        }
        //public static List<usuario> usuarioListar()
        //{
        //    return usuarioDL.usuarioListar();
        //}
        //public static int usuarioInsertar(usuario usuario)
        //{
        //    return usuarioDL.usuarioInsertar(usuario);
        //}
        //public static int usuarioActualizar(usuario usuario)
        //{
        //    return usuarioDL.usuarioActualizar(usuario);
        //}
    }
    
}
