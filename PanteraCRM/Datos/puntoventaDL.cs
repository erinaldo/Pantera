using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class puntoventaDL
    {
        public static int obtenerNumero(int idpuntoventa,string idtipo, string idmodo)
        {
            return conexion.executeScalar("fn_puntoventa_obtener_numero",
                    CommandType.StoredProcedure,
                    new parametro("in_idpuntoventa", idpuntoventa), new parametro("in_idtipo", idtipo), new parametro("in_idmodo", idmodo));
        }
        public static int aumentarNumero(int idpuntoventa, string idtipo)
        {
            return conexion.executeScalar("fn_puntoventa_aumentar_numero",
                    CommandType.StoredProcedure,
                    new parametro("in_idpuntoventa", idpuntoventa), new parametro("in_idtipo", idtipo));
        }
        public static puntoventasesion obtenerSerie(int idalmacen,int idempresa)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_puntoventa_obtener_serie", 
                CommandType.StoredProcedure, new parametro("in_idalmacen", idalmacen),
                new parametro("in_idempresa", idempresa)))
            {
                while (datareader.Read())
                {
                    return convertirRegistro(datareader);
                }
            }
            return null;
        }
        private static puntoventasesion convertirRegistro(IDataReader datareader)
        {
            puntoventasesion registro = new puntoventasesion();
            registro.idpuntoventa = Convert.ToInt32(datareader["idpuntoventa"]);
            registro.prefijopresupuesto = Convert.ToString(datareader["prefijopresupuesto"]);
            registro.prefijofactura = Convert.ToString(datareader["prefijofactura"]);
            return registro;
        }
        public static DataTable listarPorEmpresa(int idempresa)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_puntoventa_listar_por_empresa", CommandType.StoredProcedure, new parametro("in_idempresa", idempresa)))
            {
                DataTable dtCursor = new DataTable();
                dtCursor.Columns.Add("idpuntoventa", System.Type.GetType("System.Int32"));
                dtCursor.Columns.Add("idalmacen", System.Type.GetType("System.Int32"));
                dtCursor.Columns.Add("nombrepuntoventa", System.Type.GetType("System.String"));
                dtCursor.Columns.Add("prefijopresupuesto", System.Type.GetType("System.String"));
                dtCursor.Columns.Add("prefijofactura", System.Type.GetType("System.String"));

                while (datareader.Read())
                {
                    DataRow Renglon;
                    Renglon = dtCursor.NewRow();
                    Renglon[0] = Convert.ToInt32(datareader["idpuntoventa"]);
                    Renglon[1] = Convert.ToInt32(datareader["idalmacen"]);
                    Renglon[2] = Convert.ToString(datareader["nombrepuntoventa"]);
                    Renglon[3] = Convert.ToString(datareader["prefijopresupuesto"]);
                    Renglon[4] = Convert.ToString(datareader["prefijofactura"]);
                    dtCursor.Rows.Add(Renglon);
                }
                return dtCursor;
            }
        }
    }
}