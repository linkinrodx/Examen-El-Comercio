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
    public class BancoController : Controller
    {
        public readonly BancoService _BancoService;
        private readonly IConfiguration _configuration;

        public BancoController(IConfiguration configuration)
        {
            _configuration = configuration;
            _BancoService = new BancoService(_configuration);
        }

        public async Task<IActionResult> Index()
        {
            var Bancos = await Task.Run(() => _BancoService.GetBancos());

            return View(Bancos);
        }
    }
}