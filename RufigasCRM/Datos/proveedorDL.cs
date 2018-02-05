using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
namespace Datos
{
    public class proveedorDL
    {
        public static List<proveedor> proveedorListar()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_proveedor_listar", CommandType.StoredProcedure))
            {
                List<proveedor> listado = new List<proveedor>();
                while (datareader.Read())
                {
                    proveedor registro = new proveedor();
                    registro.p_inidcodigoclie = Convert.ToInt32(datareader["p_inidcodigoclie"]);
                    registro.razon = Convert.ToString(datareader["razon"]).Trim();
                    registro.tipodocu = Convert.ToString(datareader["tipodocu"]).Trim();
                    registro.nrodocumento = Convert.ToString(datareader["nrodocumento"]).Trim();
                    registro.chdireccion = Convert.ToString(datareader["chdireccion"]).Trim();
                    registro.tipoclie = Convert.ToString(datareader["tipoclie"]).Trim();
                    registro.telefono = Convert.ToString(datareader["telefono"]).Trim();                    
                    listado.Add(registro);
                }
                return listado;
            }
        }
    }
}
