using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Evaluacion_2.Models;

using Evaluacion_2.Services;
using Microsoft.Extensions.Configuration;
using Evaluacion_2.Filters;

namespace Evaluacion_2.Controllers
{
    [AccesFilter]
    public class OrdenPagoController : Controller
    {
        public readonly OrdenPagoService _OrdenPagoService;
        private readonly IConfiguration _configuration;

        public OrdenPagoController(IConfiguration configuration)
        {
            _configuration = configuration;
            _OrdenPagoService = new OrdenPagoService(_configuration);
        }

        public async Task<IActionResult> Index(int IdSucursal)
        {
            var Ordenes = await Task.Run(() => _OrdenPagoService.GetOrdenPagobyIdSucursal(IdSucursal));

            return View(Ordenes);
        }
    }
}