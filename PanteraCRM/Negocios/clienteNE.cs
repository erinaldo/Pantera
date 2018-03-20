using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocios
{
    public abstract class clienteNE
    {
        public static List<cliente> clienteListar()
        {
            return clienteDL.clienteListar();
        }
        public static List<cliente> ClienteListarParametro2(string parametro)
        {
            return clienteDL.ClienteListarParametro2(parametro);
        }
        
        public static Mcliente ClienteBusquedaCodigo(int codigo)
        {
            return clienteDL.ClienteBusquedaCodigo(codigo);
        }
        public static List<clientebusqueda> ClienteListarParametro(string parametro)
        {
            return clienteDL.ClienteListarParametro(parametro);
        }
        
        public static List<clientebusqueda> ClienteBusquedaParametro(string parametro)
        {
            return clienteDL.ClienteBusquedaParametro(parametro);
        }

        public static clientebusqueda ClienteBusquedaCodigoSecundario(string parametro)
        {
            return clienteDL.ClienteBusquedaCodigoSecundario(parametro);
        }
        public static int ClienteIngresar(Mcliente registros)
        {
            return clienteDL.ClienteIngresar(registros);
        }
        public static int ClienteModificar(Mcliente registros)
        {
            return clienteDL.ClienteModificar(registros);
        }
        public static int ClienteJuridicoIngresar(Mclientejuridico registros)
        {
            return clienteDL.ClienteJuridicoIngresar(registros);
        }
        public static int ClienteNaturalIngresar(Mclientenatural registros)
        {
            return clienteDL.ClienteNaturalIngresar(registros);
        }
        public static Mclientejuridico ClienteJuridicoBusquedaCodigo(int codigo)
        {
            return clienteDL.ClienteJuridicoBusquedaCodigo(codigo);
        }
        public static Mclientenatural ClienteNaturalBusquedaCodigo(int codigo)
        {
            return clienteDL.ClienteNaturalBusquedaCodigo(codigo);
        }
        public static List<licencia> LicenciaBusquedaCodigo(int codigo)
        {
            return clienteDL.LicenciaBusquedaCodigo(codigo);
        }
        public static List<tarjetapropiedad> TarjetaPropiedadBusquedaCodigo(int codigo)
        {
            return clienteDL.TarjetaPropiedadBusquedaCodigo(codigo);
        }
        public static int LicenciaIngresar(licencia registros)
        {
            return clienteDL.LicenciaIngresar(registros);
        }
        public static int LicenciaModificar(licencia registros)
        {
            return clienteDL.LicenciaModificar(registros);
        }
        public static int TarjetaIngresar(tarjetapropiedad registros)
        {
            return clienteDL.TarjetaIngresar(registros);
        }
        public static int TarjetaFalsear(int registros)
        {
            return clienteDL.TarjetaFalsear(registros);
        }
        public static int LicenciaFalsear(int registros)
        {
            return clienteDL.LicenciaFalsear(registros);
        }
    }
}
