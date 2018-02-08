using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
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

        public static int seriesIngresar(serie serie)
        {
            return conexion.executeScalar("fn_serieingresar",
            CommandType.StoredProcedure,
              new parametro("in_chcodigoserie", serie.chcodigoserie),
            new parametro("in_estado", serie.estado),
            new parametro("in_p_inidproducto", serie.p_inidproducto),
            new parametro("in_chadicional", serie.chadicional),
            new parametro("in_chfecha", serie.chfecha),
            new parametro("in_p_inidusuarioinsert", serie.p_inidusuarioinsert),
            new parametro("in_p_inidusuariodelete", serie.p_inidusuariodelete)

            );

        }
    }
}
