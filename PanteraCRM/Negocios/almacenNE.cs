using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public abstract class almacenNE
    {
        public static List<almacen> almacenListar(int idempresa)
        {
            return almacenDL.almacenListar(idempresa);
        }
        public static almacensesion buscarPoridalmancen(int idalmacen)
        {
            try
            {
                return almacenDL.buscarPoridalmancen(idalmacen);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public static string almacenObtenerNumero(int idalmacen,string idtipo)
        {
            string serie = almacenDL.obtenerNumero(idalmacen,idtipo).ToString().PadLeft(7,'0');
            return serie;
        }
        public static List<almacen> almacenBuscarPorEmpresa(int idempresa)
        {
            return almacenDL.buscarPorEmpresa(idempresa);
        }
        public static int almacenInsertar(almacen almacen)
        {
            return almacenDL.almacenInsertar(almacen);
        }
        public static int almacenActualizar(almacen almacen)
        {
            return almacenDL.almacenActualizar(almacen);
        }
        public static int SaldoAlmacenAdiconar(int a1, int p1, decimal cantidad)
        {
            return almacenDL.SaldoAlmacenAdiconar( a1,  p1,  cantidad);
        }
        public static int CambiarSaldoComprometido(int a1, int p1, int cantidad)
        {
            return almacenDL.CambiarSaldoComprometido(a1, p1, cantidad);
        }
    }
}
