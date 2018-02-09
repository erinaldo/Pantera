using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class reniecDL
    {
        public static persona buscarPorDNI(string dni)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_reniec_busca_por_dni",
                CommandType.StoredProcedure, new parametro("in_dni", dni)))
            {
                while (datareader.Read())
                {
                    return convertirRegistro(datareader);
                }
            }
            return null;
        }
        public static persona buscarPorNombres(string ape_paterno, string ape_materno, string nombres)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_reniec_busca_por_nombres",
                CommandType.StoredProcedure, new parametro("in_ape_paterno", ape_paterno), new parametro("in_ape_materno", ape_materno), new parametro("in_nombres", nombres)))
            {
                while (datareader.Read())
                {
                    return convertirRegistro(datareader);
                }
            }
            return null;
        }
        private static persona convertirRegistro(IDataReader datareader)
        {
            persona registro = new persona();
            registro.dni = Convert.ToString(datareader["dni"]);
            registro.ubigeo = Convert.ToString(datareader["ubigeo"]);
            registro.ape_paterno = Convert.ToString(datareader["ape_paterno"]);
            registro.ape_materno = Convert.ToString(datareader["ape_materno"]);
            registro.nombres = Convert.ToString(datareader["nombres"]);
            registro.fecha_nac = Convert.ToString(datareader["fecha_nac"]);
            registro.sexo = Convert.ToString(datareader["sexo"]);
            return registro;
        }
       
    }
}
