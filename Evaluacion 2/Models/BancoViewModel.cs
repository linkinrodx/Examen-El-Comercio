using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evaluacion_2.Models
{
    public class BancoViewModel
    {
        public int IdBanco { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string FechaRegistroStr { get; set; }
    }
}
