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
    public abstract class puntoventaNE
    {
        public static string puntoventaObtenerNumero(int idpuntoventa, string idtipo, string idmodo)
        {
//            string vNumero = puntoventaDL.obtenerNumero(idpuntoventa, idtipo).ToString().PadLeft(7, '0');
            return puntoventaDL.obtenerNumero(idpuntoventa, idtipo, idmodo).ToString().PadLeft(7, '0');
        }
        public static int puntoventaAumentarNumero(int idpuntoventa, string idtipo)
        {
            //            string vNumero = puntoventaDL.obtenerNumero(idpuntoventa, idtipo).ToString().PadLeft(7, '0');
            return puntoventaDL.aumentarNumero(idpuntoventa, idtipo);
        }

        public static List<puntoventa> PuntodeVentaListar()
        {
            return puntoventaDL.PuntodeVentaListar();
        }
        //public static DataTable listarPorEmpresa(int idempresa)
        //{
        //    return puntoventaDL.listarPorEmpresa(idempresa);
        //}


    }
}
