using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
namespace Datos
{
    public abstract class bancoDL
    {
        public static List<banco> BancoListar()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_banco_listar", CommandType.StoredProcedure))
            {
                List<banco> listado = new List<banco>();
                while (datareader.Read())
                {
                    banco registro = new banco();
                    registro.p_inidbanco = Convert.ToInt32(datareader["p_inidbanco"]);
                    registro.chnombrebanco = Convert.ToString(datareader["chnombrebanco"]).Trim();
                    registro.chtipocuenbanco = Convert.ToString(datareader["chtipocuenbanco"]).Trim();
                    registro.chcuentaban = Convert.ToString(datareader["chcuentaban"]).Trim();
                    registro.chcuentacon = Convert.ToString(datareader["chcuentacon"]).Trim();
                    registro.chcuentqamon = Convert.ToString(datareader["chcuentqamon"]).Trim();
                    registro.chcuentatel = Convert.ToString(datareader["chcuentatel"]).Trim();
                    registro.chnomsec = Convert.ToString(datareader["chnomsec"]).Trim();
                    registro.chusuarioinsert = Convert.ToInt32(datareader["chusuarioinsert"]);
                    registro.chusuariodelete = Convert.ToInt32(datareader["chusuariodelete"]);
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }
    }
}
