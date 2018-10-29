using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Conexion.BR;
using Conexion.BE;
using System.Net;
using Microsoft.Extensions.Configuration;

namespace Conexion.Controllers
{
    [Produces("application/json")]
    [Route("api/Usuario")]
    public class UsuarioController : Controller
    {
        public readonly UsuarioBR _UsuarioBR;

        public UsuarioController(IConfiguration configuration)
        {
            _UsuarioBR = new UsuarioBR(configuration);
        }

        [HttpGet("GetUsuarioByParametros")]
        [ProducesResponseType(typeof(UsuarioBE), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult GetUsuarioByParametros(string nombre, string contrasenia)
        {
            var usuario = _UsuarioBR.GetUsuarioByParametros(nombre, contrasenia);

            return Ok(usuario);
        }
    }
}