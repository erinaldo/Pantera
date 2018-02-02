using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class presupuestoDL
    {
        public static List<presupuesto> presupuestoListar(int idempresa, int idpuntoventa)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_presupuesto_listar", CommandType.StoredProcedure,
                new parametro("in_idempresa", idempresa), new parametro("in_idpuntoventa", idpuntoventa)))
            {
                List<presupuesto> listado = new List<presupuesto>();
                while (datareader.Read())
                {
                    presupuesto registro = new presupuesto();
                    registro.idpresupuesto = Convert.ToInt32(datareader["idpresupuesto"]);
                    registro.idempresa = Convert.ToInt32(datareader["idempresa"]);
                    registro.idpuntoventa = Convert.ToInt32(datareader["idpuntoventa"]);
                    registro.codigoserie = Convert.ToString(datareader["codigoserie"]);
                    registro.numeropresupuesto = Convert.ToString(datareader["numeropresupuesto"]);
                    registro.dni = Convert.ToString(datareader["dni"]);
                    registro.nombres = Convert.ToString(datareader["nombres"]);
                    registro.placa = Convert.ToString(datareader["placa"]);
                    registro.idpersona = Convert.ToInt32(datareader["idpersona"]);
                    registro.fechapresupuesto = Convert.ToString(datareader["fechapresupuesto"]);
                    registro.fecharq = Convert.ToString(datareader["fecharq"]);
                    registro.fechara = Convert.ToString(datareader["fechara"]);
                    registro.idmarca = Convert.ToInt32(datareader["idmarca"]);
                    registro.idmodelo = Convert.ToInt32(datareader["idmodelo"]);
                    registro.total = Convert.ToDecimal(datareader["total"]);
                    registro.observacion = Convert.ToString(datareader["observacion"]);
                    registro.idsitupresupuesto = Convert.ToString(datareader["idsitupresupuesto"]);
                    registro.estadopresupuesto = Convert.ToBoolean(datareader["estadopresupuesto"]);

                    listado.Add(registro);
                }
                return listado;
            }
        }

        public static List<presupuesto> presupuestoListarFechas(int idempresa, string fechaini, string fechafin, string serieini, string seriefin)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_presupuesto_listar_fechas_serie", 
                CommandType.StoredProcedure, new parametro("in_idempresa", idempresa), new parametro("in_fechaini", fechaini), 
                new parametro("in_fechafin", fechafin), new parametro("in_serieini", serieini),
                new parametro("in_seriefin", seriefin)))
            {
                List<presupuesto> listado = new List<presupuesto>();
                while (datareader.Read())
                {
                    presupuesto registro = new presupuesto();
                    registro.idpresupuesto = Convert.ToInt32(datareader["idpresupuesto"]);
                    registro.idempresa = Convert.ToInt32(datareader["idempresa"]);
                    registro.idpuntoventa = Convert.ToInt32(datareader["idpuntoventa"]);
                    registro.codigoserie = Convert.ToString(datareader["codigoserie"]);
                    registro.numeropresupuesto = Convert.ToString(datareader["numeropresupuesto"]);
                    registro.dni = Convert.ToString(datareader["dni"]);
                    registro.nombres = Convert.ToString(datareader["nombres"]);
                    registro.placa = Convert.ToString(datareader["placa"]);
                    registro.idpersona = Convert.ToInt32(datareader["idpersona"]);
                    registro.fechapresupuesto = Convert.ToString(datareader["fechapresupuesto"]);
                    registro.fecharq = Convert.ToString(datareader["fecharq"]);
                    registro.fechara = Convert.ToString(datareader["fechara"]);
                    registro.idmarca = Convert.ToInt32(datareader["idmarca"]);
                    registro.idmodelo = Convert.ToInt32(datareader["idmodelo"]);
                    registro.total = Convert.ToDecimal(datareader["total"]);
                    registro.observacion = Convert.ToString(datareader["observacion"]);
                    registro.idsitupresupuesto = Convert.ToString(datareader["idsitupresupuesto"]);
                    registro.estadopresupuesto = Convert.ToBoolean(datareader["estadopresupuesto"]);

                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static List<presupuesto> presupuestoListarFechasVendedor(int idempresa, string fechaini, string fechafin, int idusuario)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_presupuesto_listar_fechas_vendedor",
                CommandType.StoredProcedure, new parametro("in_idempresa", idempresa), new parametro("in_fechaini", fechaini),
                new parametro("in_fechafin", fechafin), new parametro("in_idusuario", idusuario)))
            {
                List<presupuesto> listado = new List<presupuesto>();
                while (datareader.Read())
                {
                    presupuesto registro = new presupuesto();
                    registro.idpresupuesto = Convert.ToInt32(datareader["idpresupuesto"]);
                    registro.idempresa = Convert.ToInt32(datareader["idempresa"]);
                    registro.idpuntoventa = Convert.ToInt32(datareader["idpuntoventa"]);
                    registro.codigoserie = Convert.ToString(datareader["codigoserie"]);
                    registro.numeropresupuesto = Convert.ToString(datareader["numeropresupuesto"]);
                    registro.dni = Convert.ToString(datareader["dni"]);
                    registro.nombres = Convert.ToString(datareader["nombres"]);
                    registro.placa = Convert.ToString(datareader["placa"]);
                    registro.idpersona = Convert.ToInt32(datareader["idpersona"]);
                    registro.fechapresupuesto = Convert.ToString(datareader["fechapresupuesto"]);
                    registro.fecharq = Convert.ToString(datareader["fecharq"]);
                    registro.fechara = Convert.ToString(datareader["fechara"]);
                    registro.idmarca = Convert.ToInt32(datareader["idmarca"]);
                    registro.idmodelo = Convert.ToInt32(datareader["idmodelo"]);
                    registro.total = Convert.ToDecimal(datareader["total"]);
                    registro.observacion = Convert.ToString(datareader["observacion"]);
                    registro.idsitupresupuesto = Convert.ToString(datareader["idsitupresupuesto"]);
                    registro.estadopresupuesto = Convert.ToBoolean(datareader["estadopresupuesto"]);

                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static presupuesto buscarPorNumeroPresuesto(int idempresa, string codigoserie, string numeropresupuesto)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_presupuesto_buscar_por_numeropresupuesto",
                CommandType.StoredProcedure, new parametro("in_idempresa", idempresa), new parametro("in_codigoserie", codigoserie), new parametro("in_numeropresupuesto", numeropresupuesto)))
            {
                while (datareader.Read())
                {
                    return convertirRegistro(datareader);
                }
            }
            return null;
        }

        public static int presupuestoInsertar(presupuesto presupuesto, DataTable presupuestodetalle, int idpuntoventa,int idusuario)
        {
            try
            {
                int ou_idpresupuesto, ou_idpresupuestodetalle = 0;
                ou_idpresupuesto = conexion.executeScalar("fn_presupuesto_insertar",
                CommandType.StoredProcedure,
                new parametro("in_idempresa", presupuesto.idempresa),
                new parametro("in_codigoserie", presupuesto.codigoserie),
                new parametro("in_numeropresupuesto", presupuesto.numeropresupuesto),
                new parametro("in_placa", presupuesto.placa),
                new parametro("in_idpersona", presupuesto.idpersona),
                new parametro("in_fechapresupuesto", presupuesto.fechapresupuesto),
                new parametro("in_fecharq", presupuesto.fecharq),
                new parametro("in_fechara", presupuesto.fechara),
                new parametro("in_idmarca", presupuesto.idmarca),
                new parametro("in_idmodelo", presupuesto.idmodelo),
                new parametro("in_total", presupuesto.total),
                new parametro("in_observacion", presupuesto.observacion),
                new parametro("in_idpuntoventa", idpuntoventa),
                new parametro("in_idusuario", idusuario));

                if (ou_idpresupuesto == 0)
                {
                    throw new Exception("Error al insertar cabecera de presupuesto ");
                }

                foreach (DataRow row in presupuestodetalle.Rows)
                {
                    ou_idpresupuestodetalle = conexion.executeScalar("fn_presupuestodetalle_insertar",
                    CommandType.StoredProcedure,
                    new parametro("in_idpresupuesto", ou_idpresupuesto),
                    new parametro("in_cantidad", (Int32)row["CANTIDAD"]),
                    new parametro("in_idarticulo", (Int32)row["IDARTICULO"]),
                    new parametro("in_precio", (decimal)row["PRECIO"]),
                    new parametro("in_subtotal", (decimal)row["SUBTOTAL"]));
                    if (ou_idpresupuestodetalle == 0)
                    {
                        throw new Exception("Error al insertar detalle de presupuesto: " + row["CONCEPTO"].ToString());
                    }
                }
                return ou_idpresupuesto;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static int presupuestoActualizar(presupuesto presupuesto, DataTable presupuestodetalle,int idusuario)
        {
            try
            {
                int ou_idpresupuesto, ou_idpresupuestodetalle = 0;
                ou_idpresupuesto = conexion.executeScalar("fn_presupuesto_actualizar",
                CommandType.StoredProcedure,
                new parametro("in_idpresupuesto", presupuesto.idpresupuesto),
                new parametro("in_idempresa", presupuesto.idempresa),
                new parametro("in_idpuntoventa", presupuesto.idpuntoventa),
                new parametro("in_codigoserie", presupuesto.codigoserie),
                new parametro("in_numeropresupuesto", presupuesto.numeropresupuesto),
                new parametro("in_placa", presupuesto.placa),
                new parametro("in_idpersona", presupuesto.idpersona),
                new parametro("in_fechapresupuesto", presupuesto.fechapresupuesto),
                new parametro("in_fecharq", presupuesto.fecharq),
                new parametro("in_fechara", presupuesto.fechara),
                new parametro("in_idmarca", presupuesto.idmarca),
                new parametro("in_idmodelo", presupuesto.idmodelo),
                new parametro("in_total", presupuesto.total),
                new parametro("in_observacion", presupuesto.observacion),
                new parametro("in_idusuario", idusuario));
                if (ou_idpresupuesto == 0)
                {
                    throw new Exception("Error al actualizar cabecera de presupuesto ");
                }

                ou_idpresupuestodetalle = presupuestoDetalleEliminar(ou_idpresupuesto);
                //if (ou_idpresupuestodetalle == 0)
                //{
                //    throw new Exception("Error al actualizar detalle de presupuesto: " );
                //}

                foreach (DataRow row in presupuestodetalle.Rows)
                {
                    ou_idpresupuestodetalle = conexion.executeScalar("fn_presupuestodetalle_insertar",
                    CommandType.StoredProcedure,
                    new parametro("in_idpresupuesto", ou_idpresupuesto),
                    new parametro("in_cantidad", (Int32)row["CANTIDAD"]),
                    new parametro("in_idarticulo", (Int32)row["IDARTICULO"]),
                    new parametro("in_precio", (decimal)row["PRECIO"]),
                    new parametro("in_subtotal", (decimal)row["SUBTOTAL"]));
                    if (ou_idpresupuestodetalle == 0)
                    {
                        throw new Exception("Error al insertar detalle de presupuesto: " + row["CONCEPTO"].ToString());
                    }
                }
                return ou_idpresupuesto;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static int presupuestoAnular(int idpresupuesto)
        {
            try
            {
                int ou_idpresupuesto = conexion.executeScalar("fn_presupuesto_anular",
                CommandType.StoredProcedure, new parametro("in_idpresupuesto", idpresupuesto));
                if (ou_idpresupuesto == 0)
                {
                    throw new Exception("Error al anular cabecera de presupuesto ");
                }
                return ou_idpresupuesto;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static int presupuestoDetalleEliminar(int idpresupuesto)
        {
           return conexion.executeScalar("fn_presupuestodetalle_eliminar",
            CommandType.StoredProcedure,
            new parametro("in_idpresupuesto", idpresupuesto));
        }
        private static presupuesto convertirRegistro(IDataReader datareader)
        {
            presupuesto registro = new presupuesto();
            registro.idpresupuesto = Convert.ToInt32(datareader["idpresupuesto"]);
            registro.idempresa = Convert.ToInt32(datareader["idempresa"]);
            registro.idpuntoventa = Convert.ToInt32(datareader["idpuntoventa"]);
            registro.codigoserie = Convert.ToString(datareader["codigoserie"]);
            registro.numeropresupuesto = Convert.ToString(datareader["numeropresupuesto"]);
            registro.placa = Convert.ToString(datareader["placa"]);
            registro.idpersona = Convert.ToInt32(datareader["idpersona"]);
            registro.fechapresupuesto = Convert.ToString(datareader["fechapresupuesto"]);
            registro.fecharq = Convert.ToString(datareader["fecharq"]);
            registro.fechara = Convert.ToString(datareader["fechara"]);
            registro.idmarca= Convert.ToInt32(datareader["idmarca"]);
            registro.idmodelo = Convert.ToInt32(datareader["idmodelo"]);
            registro.total = Convert.ToDecimal(datareader["total"]);
            registro.observacion = Convert.ToString(datareader["observacion"]);
            registro.idsitupresupuesto = Convert.ToString(datareader["idsitupresupuesto"]);
            registro.estadopresupuesto= Convert.ToBoolean(datareader["estadopresupuesto"]);
            return registro;
        }


        public static DataTable presupuestodetalleDatatable(int idpresupuesto)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_presupuestodetalle_listar", CommandType.StoredProcedure, new parametro("in_idpresupuesto", idpresupuesto)))
            {

                DataTable dtCursor = new DataTable("Detalle");
                dtCursor.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
                dtCursor.Columns.Add("idmediarticulo", System.Type.GetType("System.String"));
                dtCursor.Columns.Add("idarticulo", System.Type.GetType("System.Int32"));
                dtCursor.Columns.Add("nombrearticulo", System.Type.GetType("System.String"));
                dtCursor.Columns.Add("precio", System.Type.GetType("System.Decimal"));
                dtCursor.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));

                while (datareader.Read())
                {
                    DataRow Renglon;
                    Renglon = dtCursor.NewRow();
                    Renglon[0] = Convert.ToInt32(datareader["cantidad"]);
                    Renglon[1] = Convert.ToString(datareader["idmediarticulo"]);
                    Renglon[2] = Convert.ToInt32(datareader["idarticulo"]);
                    Renglon[3] = Convert.ToString(datareader["nombrearticulo"]);
                    Renglon[4] = Convert.ToDecimal(datareader["precio"]);
                    Renglon[5] = Convert.ToDecimal(datareader["subtotal"]);
                    dtCursor.Rows.Add(Renglon);
                }
                return dtCursor;
            }
        }

        public static List<presupuestodetalle> presupuestodetalleListar(int idpresupuesto)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_presupuestodetalle_listar", CommandType.StoredProcedure, new parametro("in_idpresupuesto", idpresupuesto)))
            {
                List<presupuestodetalle> listado = new List<presupuestodetalle>();
                while (datareader.Read())
                {
                    presupuestodetalle registro = new presupuestodetalle();
                    registro.cantidad = Convert.ToInt32(datareader["cantidad"]);
                    registro.idmediarticulo = Convert.ToString(datareader["idmediarticulo"]);
                    registro.idarticulo = Convert.ToInt32(datareader["idarticulo"]);
                    registro.nombrearticulo = Convert.ToString(datareader["nombrearticulo"]);
                    registro.precio = Convert.ToDecimal(datareader["precio"]);
                    registro.subtotal = Convert.ToDecimal(datareader["subtotal"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }

    }
}
