using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public abstract class presupuestoNE
    {
        public static List<presupuesto> presupuestoListar(int idempresa,int idpuntoventa)
        {
            return presupuestoDL.presupuestoListar(idempresa,idpuntoventa);
        }
        public static List<presupuesto> presupuestoListarFechas(int idempresa,string fechaini, string fechafin, string serieini, string seriefin)
        {
            if (fechaini.Trim().Length == 9)
            {
                fechaini = '0' + fechaini;
            }
            if (fechafin.Trim().Length == 9)
            {
                fechafin = '0' + fechafin;
            }
            return presupuestoDL.presupuestoListarFechas(idempresa, fechaini, fechafin, serieini, seriefin);
        }
        public static List<presupuesto> presupuestoListarFechasVendedor(int idempresa, string fechaini, string fechafin, int idusuario)
        {
            if (fechaini.Trim().Length == 9)
            {
                fechaini = '0' + fechaini;
            }
            if (fechafin.Trim().Length == 9)
            {
                fechafin = '0' + fechafin;
            }
            return presupuestoDL.presupuestoListarFechasVendedor(idempresa, fechaini, fechafin, idusuario);
        }
        public static int presupuestoInsertar(presupuesto presupuesto, DataTable presupuestodetalle, int idpuntoventa, int idusuario)
        {
            return presupuestoDL.presupuestoInsertar(presupuesto, presupuestodetalle, idpuntoventa, idusuario);
        }
        public static int presupuestoActualizar(presupuesto presupuesto, DataTable presupuestodetalle,int idusuario)
        {
            return presupuestoDL.presupuestoActualizar(presupuesto, presupuestodetalle,idusuario);
        }
        public static int presupuestoAnular(int idpresupuesto)
        {
            return presupuestoDL.presupuestoAnular(idpresupuesto);
        }
        public static int tramitarPersona(persona persona)
        {
            int varIdPersona;

            if (persona.idpersona <= 0)
            {
                varIdPersona = personaNE.personaInsertar(persona);
            }
            else
            {
                varIdPersona = personaNE.personaActualizar(persona);
                varIdPersona = (varIdPersona==0) ? -1 : varIdPersona;
            }
            return (varIdPersona);
        }
        public static List<presupuestodetalle> presupuestodetalleListar(int idpresupuesto)
        {
            return presupuestoDL.presupuestodetalleListar(idpresupuesto);
        }
        public static DataTable presupuestodetalleDatatable(int idpresupuesto)
        {
            return presupuestoDL.presupuestodetalleDatatable(idpresupuesto);
        }

    }
}
