using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;

namespace Conexion.BE
{
    public class SucursalBE
    {
        public SucursalBE(IDataReader reader)
        {
            IdSucursal = Convert.ToInt32(reader["IdSucursal"]);
            Nombre = Convert.ToString(reader["Nombre"]);
            Direccion = Convert.ToString(reader["Direccion"]);
            FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"]);
            IdBanco = Convert.ToInt32(reader["IdBanco"]);
        }

        public int IdSucursal { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdBanco { get; set; }
    }
}
