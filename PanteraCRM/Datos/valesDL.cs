using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
namespace Datos
{
    public abstract class valesDL
    {
        public static List<valecabecera> valesListar()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_vales_listar", CommandType.StoredProcedure))
            {
                List<valecabecera> listado = new List<valecabecera>();
                while (datareader.Read())
                {
                    valecabecera registro = new valecabecera();

                    registro.p_inidvalecebecera = Convert.ToInt32(datareader["p_inidvalecebecera"]);
                    registro.p_inidalamacen = Convert.ToInt32(datareader["p_inidalamacen"]);
                    registro.chalamacen = Convert.ToString(datareader["chalamacen"]).Trim();
                    registro.p_inidclase = Convert.ToInt32(datareader["p_inidclase"]);
                    registro.chclase = Convert.ToString(datareader["chclase"]).Trim();
                    registro.p_inidcorrevale = Convert.ToString(datareader["p_inidcorrevale"]);
                    registro.chvalefecha = Convert.ToString(datareader["chvalefecha"]).Trim();
                    registro.p_inidtipomoneda = Convert.ToInt32(datareader["p_inidtipomoneda"]);
                    registro.chtipomoneda = Convert.ToString(datareader["chtipomoneda"]).Trim();
                    registro.p_inidproveedor = Convert.ToInt32(datareader["p_inidproveedor"]);
                    registro.chcodigoproveedor = Convert.ToString(datareader["chcodigoproveedor"]).Trim();
                    registro.chguiaremision = Convert.ToString(datareader["chguiaremision"]).Trim();
                    registro.chboletafactura = Convert.ToString(datareader["chboletafactura"]).Trim();
                    registro.p_inidtipomoviemiento = Convert.ToInt32(datareader["p_inidtipomoviemiento"]);
                    registro.chtipomoviemiento = Convert.ToString(datareader["chtipomoviemiento"]).Trim();
                    registro.chobservacion = Convert.ToString(datareader["chobservacion"]).Trim();
                    registro.p_inidusuarioinsert = Convert.ToInt32(datareader["p_inidusuarioinsert"]);
                    registro.chusuarioinsert = Convert.ToString(datareader["chusuarioinsert"]).Trim();
                    registro.p_inidusuariodelete = Convert.ToInt32(datareader["p_inidusuariodelete"]);
                    registro.chusuariodelete = Convert.ToString(datareader["chusuariodelete"]).Trim();
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static int generarCorelativoIngresar()
        {
            return conexion.executeScalar("fn_vale_correlativo", CommandType.StoredProcedure);

        }
        
    }
}
