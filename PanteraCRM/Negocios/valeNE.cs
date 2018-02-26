using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocios
{
    public abstract class valeNE
    {
        public static List<valecabecera> valesListar(int tipo)
        {
            return valesDL.valesListar(tipo);
        }
        public static List<valecabecera> valesListarparmetro(int tipo,string parametro)
        {
            return valesDL.valesListarparmetro(tipo,parametro);
        }
        
        public static int CorrelativoMovimientoIngreso(int parametro)
        {
            return valesDL.CorrelativoMovimientoIngreso(parametro);
        }

        public static int CorrelativoMovimientoSalida(int parametro)
        {
            return valesDL.CorrelativoMovimientoSalida(parametro);
        }
        public static int GenerarCorrelativoMovimientoIngreso(int parametro)
        {
            return valesDL.GenerarCorrelativoMovimientoIngreso(parametro);
        }
        public static int GenerarCorrelativoMovimientoSalida(int parametro)
        {
            return valesDL.GenerarCorrelativoMovimientoSalida(parametro);
        }
    }
}
