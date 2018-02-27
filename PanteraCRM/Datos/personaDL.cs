using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class personaDL
    {
        public static int PersonaIngresar(persona registros)
        {
            return conexion.executeScalar("fn_persona_ingresar",
            CommandType.StoredProcedure,
            new parametro("in_nrodocumento", registros.nrodocumento),
            new parametro("in_chapellidopaterno", registros.chapellidopaterno),
            new parametro("in_chapellidomaterno", registros.chapellidomaterno),
            new parametro("in_chnombres", registros.chnombres),
            new parametro("in_p_inidtiposexo", registros.p_inidtiposexo),
            new parametro("in_chtelefono", registros.chtelefono),
            new parametro("in_chdireccion", registros.chdireccion),
            new parametro("in_estado", registros.estado),
            new parametro("in_p_inidubigeo", registros.p_inidubigeo ),
            new parametro("in_p_inidtipodocumento", registros.p_inidtipodocumento ));

        }
        //    public static List<persona> personaListar()
        //    {
        //        using (IDataReader datareader = conexion.executeOperation("fn_persona_listar", CommandType.StoredProcedure))
        //        {
        //            List<persona> listado = new List<persona>();
        //            while (datareader.Read())
        //            {
        //                persona registro = new persona();
        //                registro.idpersona = Convert.ToInt32(datareader["idpersona"]);
        //                registro.dni = Convert.ToString(datareader["dni"]);
        //                registro.ubigeo = Convert.ToString(datareader["ubigeo"]).Trim();
        //                registro.ape_paterno = Convert.ToString(datareader["ape_paterno"]).Trim();
        //                registro.ape_materno = Convert.ToString(datareader["ape_materno"]).Trim();
        //                registro.nombres = Convert.ToString(datareader["nombres"]);
        //                registro.fecha_nac = Convert.ToString(datareader["fecha_nac"]);
        //                registro.sexo = Convert.ToString(datareader["sexo"]);
        //                registro.telefono = Convert.ToString(datareader["telefono"]);
        //                registro.direccion = Convert.ToString(datareader["direccion"]);
        //                listado.Add(registro);
        //            }
        //            return listado;
        //        }
        //    }

        //    public static persona buscarPorDNI(string dni)
        //    {
        //        using (IDataReader datareader = conexion.executeOperation("fn_persona_busca_por_dni", 
        //            CommandType.StoredProcedure, new parametro("in_dni", dni)))
        //        {
        //            while (datareader.Read())
        //            {
        //                return convertirRegistro(datareader);
        //            }
        //        }
        //        return null;
        //    }

        //public static persona buscarPorIdpersona(int idpersona)
        //{
        //    using (IDataReader datareader = conexion.executeOperation("fn_persona_busca_por_idpersona",
        //        CommandType.StoredProcedure, new parametro("in_idpersona", idpersona)))
        //    {
        //        while (datareader.Read())
        //        {
        //            return convertirRegistro(datareader);
        //        }
        //    }
        //    return null;
        //}
        //public static int personaInsertar(persona persona)
        //    {
        //        return conexion.executeScalar("fn_persona_insertar",
        //        CommandType.StoredProcedure,
        //        new parametro("in_dni", persona.dni),
        //        new parametro("in_ubigeo", persona.ubigeo),
        //        new parametro("in_ape_paterno", persona.ape_paterno),
        //        new parametro("in_ape_materno", persona.ape_materno),
        //        new parametro("in_nombres", persona.nombres),
        //        new parametro("in_fecha_nac", persona.fecha_nac),
        //        new parametro("in_sexo", persona.sexo),
        //        new parametro("in_telefono", persona.telefono),
        //        new parametro("in_direccion", persona.direccion));
        //    }
        //    public static int personaActualizar(persona persona)
        //    {
        //        return conexion.executeScalar("fn_persona_actualizar",
        //        CommandType.StoredProcedure,
        //        new parametro("in_idpersona", persona.idpersona),
        //        new parametro("in_dni", persona.dni),
        //        new parametro("in_ubigeo", persona.ubigeo),
        //        new parametro("in_ape_paterno", persona.ape_paterno),
        //        new parametro("in_ape_materno", persona.ape_materno),
        //        new parametro("in_nombres", persona.nombres),
        //        new parametro("in_fecha_nac", persona.fecha_nac),
        //        new parametro("in_sexo", persona.sexo),
        //        new parametro("in_telefono", persona.telefono),
        //        new parametro("in_direccion", persona.direccion));
        //    }
        //    private static persona convertirRegistro(IDataReader datareader)
        //    {
        //        persona registro = new persona();
        //        registro.idpersona = Convert.ToInt32(datareader["idpersona"]);
        //        registro.dni = Convert.ToString(datareader["dni"]);
        //        registro.ubigeo = Convert.ToString(datareader["ubigeo"]);
        //        registro.ape_paterno = Convert.ToString(datareader["ape_paterno"]);
        //        registro.ape_materno = Convert.ToString(datareader["ape_materno"]);
        //        registro.nombres = Convert.ToString(datareader["nombres"]);
        //        registro.fecha_nac = Convert.ToString(datareader["fecha_nac"]);
        //        registro.sexo = Convert.ToString(datareader["sexo"]);
        //    registro.telefono = Convert.ToString(datareader["telefono"]);
        //    registro.direccion = Convert.ToString(datareader["direccion"]);
        //        return registro;
        //    }
    }
}
