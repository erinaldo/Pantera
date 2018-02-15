using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
namespace Datos
{
    public abstract class transportistaDL
    {
        public static List<transportista> TransportistaGeneral()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_transportista_listar", CommandType.StoredProcedure))
            {
                List<transportista> listado = new List<transportista>();
                while (datareader.Read())
                {
                    transportista registro = new transportista();
                    registro.p_inidtransportista = Convert.ToInt32(datareader["p_inidtransportista"]);
                    registro.chnombretransportista = Convert.ToString(datareader["chnombretransportista"]).Trim();
                    registro.chnombrecomercial = Convert.ToString(datareader["chnombrecomercial"]).Trim();
                    registro.chdireccionfiscal = Convert.ToString(datareader["chdireccionfiscal"]).Trim();
                    registro.chruc = Convert.ToString(datareader["chruc"]).Trim();
                    listado.Add(registro);
                }
                return listado;
            }
        }
    }
}
