using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocios
{
    public abstract class conductorNE
    {
        public static List<conductor> ListaConductoresPorTransportista(int parametro)
        {
            return conductorDL.Listaconductores(parametro);
        }
    }
}
