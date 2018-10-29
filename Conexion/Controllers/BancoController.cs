using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Conexion.BR;
using Conexion.BE;
using System.Net;
using Microsoft.Extensions.Configuration;

namespace Conexion.Controllers
{
    [Produces("application/json")]
    [Route("api/Banco")]
    public class BancoController : Controller
    {
        public readonly BancoBR _BancoBR;

        public BancoController(IConfiguration configuration)
        {
            _BancoBR = new BancoBR(configuration);
        }

        [HttpGet("GetBancos")]
        [ProducesResponseType(typeof(List<BancoBE>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult GetBancos()
        {
            var ListaBancos = _BancoBR.GetBancos();
            
            return Ok(ListaBancos);
        }
    }
}
