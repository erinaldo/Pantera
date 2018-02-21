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
    }
}
