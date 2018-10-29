using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evaluacion_2.Models
{
    public class UsuarioViewModel
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }
        public int RolId { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
