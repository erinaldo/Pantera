using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
namespace Datos
{
    public abstract class acesoDL
    {
        public static sessionglobal buscarAcesoPorLoginClaveDL(string login, string clave)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_usuario_buscar_por_login_y_clave", CommandType.StoredProcedure, new parametro("in_login", login), new parametro("in_clave", clave)))
            {
                while (datareader.Read())
                {
                    return convertirRegistro(datareader);
                }
            }
            return null;
        }
        private static sessionglobal convertirRegistro(IDataReader datareader)
        {
            sessionglobal registro = new sessionglobal();
            registro.p_inidusuario = Convert.ToInt32(datareader["p_inidusuario"]);
            registro.p_inidpersona = Convert.ToInt32(datareader["p_inidusuario"]);
            registro.p_inidpuntoventa = Convert.ToInt32(datareader["p_inidpuntoventa"]);
            registro.p_inidperfil = Convert.ToInt32(datareader["p_inidperfil"]);
            registro.chnombrepersona = Convert.ToString(datareader["chnombres"]);
            registro.chusuario = Convert.ToString(datareader["chusuario"]);
            registro.estado = Convert.ToBoolean(datareader["estado"]);
            return registro;
        }
    }
}
