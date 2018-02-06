using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Datos
{
    public abstract class serieDL
    {
        public static bool verificarExistencias(string parametro)
        {
            bool flat = false;
            int flat2 = 0;
            using (IDataReader datareader = conexion.executeOperation("fn_serie_validarexistencia",
                CommandType.StoredProcedure, new parametro("in_seriecodigo", parametro)))
            {
                
                while (datareader.Read())
                {
                   flat2 = Convert.ToInt32(datareader["out_existencia"]);
                }
            }
            if (flat2 > 0)
            {
                flat = true;
            }    


            
            return flat;
        }
    }
}
