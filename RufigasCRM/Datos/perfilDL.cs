using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using Entidades;

namespace Datos
{
    public abstract class perfilDL
    {
        public static List<perfil> perfilListar()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_perfil_listar", CommandType.StoredProcedure))
            {
                List<perfil> listado = new List<perfil>();
                while (datareader.Read())
                {
                    perfil registro = new perfil();
                    registro.idperfil = Convert.ToInt32(datareader["idperfil"]);
                    registro.descripcion = Convert.ToString(datareader["descripcion"]).Trim();
                    registro.comentarioperfil = Convert.ToString(datareader["comentarioperfil"]).Trim();
                    registro.estadoperfil = Convert.ToBoolean(datareader["estadoperfil"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }

        
        public static int perfilInsertar(perfil perfil)
        {
            {
                return conexion.executeScalar("fn_perfil_insertar",
                CommandType.StoredProcedure,
                new parametro("in_descripcion", perfil.descripcion),
                new parametro("in_comentarioperfil", perfil.comentarioperfil),
                new parametro("in_estadoperfil", perfil.estadoperfil));
            }
        }
        public static int perfilActualizar(perfil perfil)
        {
            {
                return conexion.executeScalar("fn_perfil_actualizar",
                CommandType.StoredProcedure,
                new parametro("in_idperfil", perfil.idperfil),
                new parametro("in_descripcion", perfil.descripcion),
                new parametro("in_comentarioperfil", perfil.comentarioperfil),
                new parametro("in_estadoperfil", perfil.estadoperfil));
            }
        }
        private static perfil convertirRegistro(IDataReader datareader)
        {
            perfil registro = new perfil();
            registro.idperfil = Convert.ToInt32(datareader["idperfil"]);
            registro.descripcion = Convert.ToString(datareader["descripcion"]);
            registro.comentarioperfil = Convert.ToString(datareader["comentarioperfil"]);
            registro.estadoperfil= Convert.ToBoolean(datareader["estadoperfil"]);
            return registro;
        }

    }
}
