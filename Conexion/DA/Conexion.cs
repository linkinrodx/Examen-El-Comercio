using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Conexion.BE;
using Microsoft.Extensions.Configuration;

namespace Conexion.DA
{
    public class ConexionBD
    {
        private readonly IConfiguration _configuration;

        public ConexionBD(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public SqlDataReader GetTabla(string comando)
        {
            var path = System.Environment.CurrentDirectory;
            string connectionString = string.Format(_configuration.GetConnectionString("DefaultConnection"), path);

            var listabancos = new List<BancoBE>();
            SqlDataReader reader = null;

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(comando, connection);                    
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    return reader;
                }
            }
            catch (Exception ex)
            {
                reader = null;
            }

            return reader;
        }
    }
}
