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
    [Route("api/OrdenPago")]
    public class OrdenPagoController : Controller
    {
        public readonly OrdenPagoBR _OrdenPagoBR;

        public OrdenPagoController(IConfiguration configuration)
        {
            _OrdenPagoBR = new OrdenPagoBR(configuration);
        }

        [HttpGet("GetOrdenesPagobyIdSucursal")]
        [ProducesResponseType(typeof(List<BancoBE>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult GetOrdenesPagobyIdSucursal(int IdSucursal, string moneda = "")
        {
            var ListaBancos = _OrdenPagoBR.GetOrdenesPagobyIdSucursal(IdSucursal, moneda);

            return Ok(ListaBancos);
        }
    }
}