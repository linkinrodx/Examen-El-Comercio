using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;

namespace Conexion.BE
{
    public class BancoBE
    {
        public BancoBE(IDataReader reader)
        {
            IdBanco = Convert.ToInt32(reader["IdBanco"]);
            Nombre = Convert.ToString(reader["Nombre"]);
            Direccion = Convert.ToString(reader["Direccion"]);
            FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"]);
        }

        public int IdBanco { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
