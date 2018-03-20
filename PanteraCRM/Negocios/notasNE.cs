using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocios
{
    public abstract class notasNE
    {
        public static int NotaCabeceraIngresar(notacreditocabecera parametro)
        {
            return notasDL.NotaCreditoCabeceraIngresar(parametro);
        }
        public static int NotaDetalleIngresar(notacreditodetalle parametro)
        {
            return notasDL.NotaCreditoDetalleIngresar(parametro);
        }
        public static int NotaDebitoIngresar(notadebito parametro)
        {
            return notasDL.NotaDebitoIngresar(parametro);
        }
    }
}
