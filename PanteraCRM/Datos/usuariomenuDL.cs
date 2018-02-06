using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Newtonsoft.Json;
using Entidades;

namespace Datos
{
    public abstract class usuariomenuDL
    {
        public static List<menu> obtieneEstructura()
        {
            List<menu> listado = null;
            using (IDataReader datareader = conexion.executeOperation("select * from vw_menu_json", CommandType.Text))
            {
                while (datareader.Read())
                {
                    var json = datareader[0].ToString();
                    listado = JsonConvert.DeserializeObject<List<menu>>(json);
                }
            }
            return listado;
        }

        private static menu convertirRegistro(IDataReader datareader)
        {
            menu registro = new menu();

            registro.idmenu = Convert.ToInt32(datareader["p_inidmenu"]);
            registro.codigomenu = Convert.ToInt32(datareader["chcodigomenu"]);
            registro.descripcion= Convert.ToString(datareader["chdescripcionmenu"]);
            registro.icono = Convert.ToString(datareader["chiconomenu"]);
            registro.orden = Convert.ToInt32(datareader["inorden"]);
            registro.instancia = Convert.ToString(datareader["chinstancia"]);
            return registro;
        }
        //public static List<usuariomenu> usuariomenuListar(int idusuario)
        //{
        //    using (IDataReader datareader = conexion.executeOperation("fn_usuariomenu_listar", CommandType.StoredProcedure, new Parameter("in_idusuario", idusuario),
        //        new Parameter("in_idusuario", idusuario)))
        //    {
        //        List<usuariomenu> listado = new List<usuariomenu>();
        //        while (datareader.Read())
        //        {
        //            usuariomenu registro = new usuariomenu();

        //            registro.idmenu = Convert.ToInt32(datareader["idmenu"]);
        //            registro.descripcion = Convert.ToString(datareader["descripcion"]);
        //            registro.seleccion = Convert.ToBoolean(datareader["seleccion"]);
        //            listado.Add(registro);
        //        }
        //        return listado;
        //    }
        //}
    }
}
