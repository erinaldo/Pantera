using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class personaNE
    {
        public static persona buscaPorDNI(string dni)
        {
            try
            {
                return personaDL.buscarPorDNI(dni);
            }

            catch (Exception)
            {
                throw;
                //Console.WriteLine("{0} Exception caught.", e);
            }
        }
        public static persona buscaPorIdpersona(int idpersona)
        {
            try
            {
                return personaDL.buscarPorIdpersona(idpersona);
            }

            catch (Exception)
            {
                throw;
                //Console.WriteLine("{0} Exception caught.", e);
            }
        }
        public static List<persona> personaListar()
        {
            return personaDL.personaListar();
        }
        public static int personaInsertar(persona persona)
        {
            return personaDL.personaInsertar(persona);
        }
        public static int personaActualizar(persona persona)
        {
            return personaDL.personaActualizar(persona);
        }
    }
}
