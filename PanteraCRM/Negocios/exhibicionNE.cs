using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocios
{
    public abstract class exhibicionNE
    {
        public static List<productoserie> ListaProductosSerieExhibicion()
        {
            return exhibicionDL.ListaProductosSerieExhibicion();
        }
        public static List<productoserie> ListaProductosSerieExhibicionParametro(string parametro)
        {
            return exhibicionDL.ListaProductosSerieExhibicionParametro(parametro);
        }
        public static int ExibicionIngresar(int p_inidserie, string chinforme, string chinformeobs, string chinformefecha, bool boexhibicion)
        {
            return exhibicionDL.ExibicionIngresar( p_inidserie,  chinforme,  chinformeobs,  chinformefecha,  boexhibicion);
        }        
    }
}
