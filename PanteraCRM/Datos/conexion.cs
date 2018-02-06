using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Npgsql;

namespace Datos
{
    public abstract class conexion
    {
        private static NpgsqlConnection enlace { get; set; }
        public static NpgsqlConnection getconexion()
        {
            if (enlace == null)
            {
                enlace = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["LINQ_PGSQL"].ToString());
                enlace.Open();
            }
            return enlace;
        }
        private static NpgsqlCommand prepareExecute(string consulta, CommandType tipo, params parametro[] args)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = getconexion();
            cmd.CommandType = tipo;
            cmd.CommandText = consulta;

            foreach (parametro argument in args)
            {
                cmd.Parameters.Add(new NpgsqlParameter(argument.key, argument.value));
            }
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            return cmd;
        }
        public static IDataReader executeOperation(string consulta, CommandType tipo = CommandType.Text)

        {
            using (NpgsqlCommand cmd = prepareExecute(consulta, tipo))
            {
                return cmd.ExecuteReader();
            }
        }
        public static string executeOperationStr(string consulta, CommandType tipo)

        {
            using (NpgsqlCommand cmd = prepareExecute(consulta, tipo))
            {
                return cmd.ExecuteReader().ToString();
            }
        }
        public static IDataReader executeOperation(string consulta, CommandType tipo, params parametro[] args)
        {
            using (NpgsqlCommand cmd = prepareExecute(consulta, tipo, args))
            {
                return cmd.ExecuteReader();
            }
        }

        public static int executeScalar(string consulta, CommandType tipo, params parametro[] args)
        {
            Int32 newProdID = 0;
            using (NpgsqlCommand cmd = prepareExecute(consulta, tipo, args))
            try
            {
                newProdID = (Int32)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return (int)newProdID;
        }
        public static string executeScalarStr(string consulta, CommandType tipo, params parametro[] args)
        {
            string newProdID = "";
            using (NpgsqlCommand cmd = prepareExecute(consulta, tipo, args))
                try
                {
                    newProdID = cmd.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            return (string)newProdID;
        }
        public static string executeScalarStr(string consulta, CommandType tipo)
        {
            string newProdID = "";
            using (NpgsqlCommand cmd = prepareExecute(consulta, tipo))
                try
                {
                    newProdID = cmd.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            return (string)newProdID;
        }
    }
}
