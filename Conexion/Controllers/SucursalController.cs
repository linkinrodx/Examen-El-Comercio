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
    [Route("api/Sucursal")]
    public class SucursalController : Controller
    {
        public readonly SucursalBR _SucursalBR;

        public SucursalController(IConfiguration configuration)
        {
            _SucursalBR = new SucursalBR(configuration);
        }

        [HttpGet("GetSucursalesbyIdBanco")]
        [ProducesResponseType(typeof(List<SucursalBE>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult GetSucursalesbyIdBanco(int IdBanco)
        {
            var ListaSucurales = _SucursalBR.GetSucursalesbyIdBanco(IdBanco);

            return Ok(ListaSucurales);
        }
    }
}