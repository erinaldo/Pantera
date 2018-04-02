using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;

namespace Datos
{
    public abstract class usuarioDL
    {
        public static List<modulos> ModulosListar()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_modulos_listar", CommandType.StoredProcedure))
            {
                List<modulos> listado = new List<modulos>();
                while (datareader.Read())
                {
                    modulos registro = new modulos();
                    registro.p_inidmenu = Convert.ToInt32(datareader["p_inidmenu"]);
                    registro.chcodigomenu = Convert.ToInt32(datareader["chcodigomenu"]);
                    registro.chdescripcionmenu = Convert.ToString(datareader["chdescripcionmenu"]).Trim();
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static List<usuariomenu> UsuarioListar()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_usuario_listar", CommandType.StoredProcedure))
            {
                List<usuariomenu> listado = new List<usuariomenu>();
                while (datareader.Read())
                {
                    usuariomenu registro = new usuariomenu();
                    registro.p_inidusuario = Convert.ToInt32(datareader["p_inidusuario"]);
                    registro.p_inidpersona = Convert.ToInt32(datareader["p_inidpersona"]);
                    registro.p_inidpuntoventa = Convert.ToInt32(datareader["p_inidpuntoventa"]);
                    registro.chclave = Convert.ToString(datareader["chclave"]).Trim();
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    registro.p_inidperfil = Convert.ToInt32(datareader["p_inidperfil"]);
                    registro.chusuario = Convert.ToString(datareader["chusuario"]).Trim();
                    registro.chprivilegios = Convert.ToString(datareader["chprivilegios"]).Trim();
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static List<usuariomenu> UsuarioListarParametro(string parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_usuario_listar_parametro", CommandType.StoredProcedure, new parametro("in_parametro",parametro) ))
            {
                List<usuariomenu> listado = new List<usuariomenu>();
                while (datareader.Read())
                {
                    usuariomenu registro = new usuariomenu();
                    registro.p_inidusuario = Convert.ToInt32(datareader["p_inidusuario"]);
                    registro.p_inidpersona = Convert.ToInt32(datareader["p_inidpersona"]);
                    registro.p_inidpuntoventa = Convert.ToInt32(datareader["p_inidpuntoventa"]);
                    registro.chclave = Convert.ToString(datareader["chclave"]).Trim();
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    registro.p_inidperfil = Convert.ToInt32(datareader["p_inidperfil"]);
                    registro.chusuario = Convert.ToString(datareader["chusuario"]).Trim();
                    registro.chprivilegios = Convert.ToString(datareader["chprivilegios"]).Trim();
                    listado.Add(registro);
                }
                return listado;
            }
        }
        

        public static usuario buscarPorLoginClave(string login, string clave)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_usuario_buscar_por_login_y_clave", CommandType.StoredProcedure, new parametro("in_login", login),
                new parametro("in_clave", clave)))
            {
                while (datareader.Read())
                {
                    return convertirRegistro(datareader);
                }
            }
            return null;
        }
        private static usuario convertirRegistro(IDataReader datareader)
        {
            usuario registro = new usuario();
            registro.p_inidusuario = Convert.ToInt32(datareader["idusuario"]);
            registro.nombre = Convert.ToString(datareader["nombre"]).Trim();
            registro.chusuario = Convert.ToString(datareader["login"]).Trim();
            registro.estado = Convert.ToBoolean(datareader["estadousuario"]);
            registro.p_inidperfil = Convert.ToInt32(datareader["idperfil"]);
            registro.descripcion = Convert.ToString(datareader["descripcion"]).Trim();
            return registro;
        }
        public static usuario buscarPorCodigo(int idusuario)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_usuario_busqueda_codigo", CommandType.StoredProcedure, new parametro("in_parametro", idusuario)))
            {
                while (datareader.Read())
                {
                    usuario registro = new usuario();

                    registro.p_inidusuario = Convert.ToInt32(datareader["p_inidusuario"]);
                    registro.p_inidpersona = Convert.ToInt32(datareader["p_inidpersona"]);
                    registro.chusuario = Convert.ToString(datareader["chusuario"]).Trim();
                    registro.chclave = Convert.ToString(datareader["chclave"]).Trim();
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    registro.p_inidpuntoventa = Convert.ToInt32(datareader["p_inidpuntoventa"]);
                    registro.p_inidperfil = Convert.ToInt32(datareader["p_inidperfil"]);                    
                    return registro;

                }
            }
            return null;
        }
        //private static usuariosesion convertirRegistroParcial(IDataReader datareader)
        //{
        //    usuariosesion registro = new usuariosesion();
        //    registro.idusuario = Convert.ToInt32(datareader["idusuario"]);
        //    registro.nombre = Convert.ToString(datareader["nombre"]);
        //    registro.login = Convert.ToString(datareader["login"]);
        //    registro.idperfil = Convert.ToInt32(datareader["idperfil"]);
        //    return registro;
        //}
        public static int UsuarioIngresar(usuariomenu usuario)
        {
            return conexion.executeScalar("fn_usuario_ingresar",
            CommandType.StoredProcedure,
            //new parametro("in_p_inidusuario", usuario.p_inidusuario),
            new parametro("in_p_inidpersona", usuario.p_inidpersona),
            new parametro("in_p_inidpuntoventa", usuario.p_inidpuntoventa),
            new parametro("in_chclave", usuario.chclave),
            new parametro("in_estado", usuario.estado),
            new parametro("in_p_inidperfil", usuario.p_inidperfil),
            new parametro("in_chusuario", usuario.chusuario ),
            new parametro("in_chprivilegios", usuario.chprivilegios)
                );
        }

        //public static int usuarioActualizar(usuario usuario)
        //{
        //        return conexion.executeScalar("fn_usuario_actualizar",
        //        CommandType.StoredProcedure,
        //        new parametro("in_idusuario", usuario.idusuario),
        //        new parametro("in_nombre", usuario.nombre),
        //        new parametro("in_login", usuario.login),
        //        new parametro("in_clave", usuario.clave),
        //        new parametro("in_estadousuario", usuario.estadousuario),
        //        new parametro("in_idperfil", usuario.idperfil));
        //}
    }
}
