using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evaluacion_2.Models
{
    public class OrdenPagoViewModel
    {
        public int IdOrden { get; set; }
        public string Monto { get; set; }
        public string Moneda { get; set; }
        public string Estado { get; set; }
        public DateTime FechaPago { get; set; }
        public string FechaPagoStr { get; set; }
        public int? IdSucursal { get; set; }
    }
}
