using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class perfildetalleDL
    {
        public static List<perfildetalle> perfildetalleListar(int idperfil)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_perfildetalle_listar", CommandType.StoredProcedure, new parametro("in_idperfil", idperfil)))
            {
                List<perfildetalle> listado = new List<perfildetalle>();
                while (datareader.Read())
                {
                    perfildetalle registro = new perfildetalle();

                    registro.idmenu = Convert.ToInt32(datareader["idmenu"]);
                    registro.descripcion = Convert.ToString(datareader["descripcion"]);
                    registro.seleccion = Convert.ToBoolean(datareader["seleccion"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }

        public static int perfildetalleInsertar(int idperfil,perfildetalle perfildetalle)
        {
            {
                return conexion.executeScalar("fn_perfildetalle_insertar",
                CommandType.StoredProcedure,
                new parametro("in_idperfil", idperfil),
                new parametro("in_idmenu", perfildetalle.idmenu));
            }
        }
        public static int perfildetalleEliminar(int idperfil)
        {
            {
                return conexion.executeScalar("fn_perfildetalle_eliminar",
                CommandType.StoredProcedure,
                new parametro("in_idperfil", idperfil));
            }
        }
        public static int validarModulo(int idperfil, int idmenu)
        {
            return conexion.executeScalar("fn_perfildetalle_validar",
                    CommandType.StoredProcedure,
                    new parametro("in_idperfil", idperfil),
                    new parametro("in_idmenu", idmenu));
        }
    }
}
