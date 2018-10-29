using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;

namespace Conexion.BE
{
    public enum ERolUsuario : int
    {
        Administrador = 1,
        Operador1 = 2,
        Operador2 = 3
    }

    public class UsuarioBE
    {
        public UsuarioBE(IDataReader reader)
        {
            IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
            Nombre = Convert.ToString(reader["Nombre"]);
            Estado = Convert.ToInt32(reader["Estado"]);
            RolId = Convert.ToInt32(reader["RolId"]);
            FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"]);
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }
        public int RolId { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
