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
    public static class articuloNE
    {
        public static List<articulo> articuloListar()
        {
            return articuloDL.articuloListar();
        }
        public static List<articulopresupuesto> articuloListarPresupuesto()
        {
            return articuloDL.articuloListarPresupuesto();
        }
        public static int articuloInsertar(articulo articulo)
        {
            return articuloDL.articuloInsertar(articulo);
        }
        //public static string articuloObtenerNumero(int idtipoarticulo,int idcatearticulo)
        //{
        //    return articuloDL.obtenerNumero(idtipoarticulo,idcatearticulo);
        //}
        public static int articuloActualizar(producto articulo)
        {
            return articuloDL.articuloActualizar(articulo);
        }
        public static DataTable articuloReporteTotalCantidadPorVendedor(int idusuario,string fechaini,string fechafin)
        {
            if (fechaini.Trim().Length == 9)
            {
                fechaini = '0' + fechaini;
            }
            if (fechafin.Trim().Length == 9)
            {
                fechafin = '0' + fechafin;
            }
            return articuloDL.articuloReporteTotalCantidadPorVendedor(idusuario,  fechaini,  fechafin);
        }
        public static DataTable articuloReporteTotalCantidadTodos(string fechaini, string fechafin)
        {
            if (fechaini.Trim().Length == 9)
            {
                fechaini = '0' + fechaini;
            }
            if (fechafin.Trim().Length == 9)
            {
                fechafin = '0' + fechafin;
            }
            return articuloDL.articuloReporteTotalCantidadTodos(fechaini, fechafin);
        }
    }
}