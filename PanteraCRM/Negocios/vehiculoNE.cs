using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocios
{
    public abstract class vehiculoNE
    {
        public static List<vehiculo> ListaVehiculosPorTransportista(int parametro)
        {
            return vechiculoDL.ListadoVehiculos(parametro);
        }
    }
}
