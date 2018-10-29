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
    public class SucursalController : Controller
    {
        public readonly SucursalService _SucursalService;
        private readonly IConfiguration _configuration;

        public SucursalController(IConfiguration configuration)
        {
            _configuration = configuration;
            _SucursalService = new SucursalService(_configuration);
        }

        public async Task<IActionResult> Index(int IdBanco)
        {
            var sucursales = await Task.Run(() => _SucursalService.GetSucursalesbyIdBanco(IdBanco));

            return View(sucursales);
        }
    }
}