using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocios
{
    public abstract class movimientosNE
    {
        public static int MovimientoProductoCabeceraIngresar(movimientoproductoc registros)
        {
            return movimientosDL.MovimientoProductoCabeceraIngresar(registros);
        }
        public static int MovimientoProductoDetalleIngresar(movimientoproductod registros)
        {
            return movimientosDL.MovimientoProductoDetalleIngresar(registros);
        }
        public static movimientoproductoc MovimientoProductoCabeceraBusqueda(int codigo)
        {
            return movimientosDL.MovimientoProductoCabeceraBusqueda(codigo);
        }
        public static List<valedetalle> MovimientoProductoDetalleBusqueda(int codigo)
        {
            return movimientosDL.MovimientoProductoDetalleBusqueda(codigo);
        }
        public static int MovimientoProductoDetalleFalsear(int registros)
        {
            return movimientosDL.MovimientoProductoDetalleFalsear(registros);
        }
        public static int MovimientoProductoCabeceraModificar(movimientoproductoc codigo)
        {
            return movimientosDL.MovimientoProductoCabeceraModificar(codigo);
        }
        public static int MovimientoProductoCabeceraFalsear(int registros)
        {
            return movimientosDL.MovimientoProductoCabeceraFalsear(registros);
        }
        public static List<kardexdetalle> ListarKardexBusquedaCodigo(int codigo)
        {
            return movimientosDL.ListarKardexBusquedaCodigo(codigo);
        }
    }
}
