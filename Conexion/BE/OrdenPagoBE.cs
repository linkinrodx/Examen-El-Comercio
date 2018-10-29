using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;

namespace Conexion.BE
{
    public enum EEstadoOrden : int
    {
        pagada = 1,
        declinada = 2,
        fallida = 3,
        anulada = 4,
    }

    public class OrdenPagoBE
    {
        public OrdenPagoBE(IDataReader reader)
        {
            IdOrden = Convert.ToInt32(reader["IdOrden"]);
            Monto = Convert.ToDecimal(reader["Monto"]);
            Moneda = Convert.ToString(reader["Moneda"]);
            Estado = Convert.ToInt32(reader["Estado"]);
            FechaPago = Convert.ToDateTime(reader["FechaPago"]);
            IdSucursal = reader["IdSucursal"] as int?;
        }

        public int IdOrden { get; set; }
        public decimal Monto { get; set; }
        public string Moneda { get; set; }
        public int Estado { get; set; }
        public DateTime FechaPago { get; set; }
        public int? IdSucursal { get; set; }
    }
}
