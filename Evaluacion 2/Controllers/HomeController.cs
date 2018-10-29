using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Evaluacion_2.Models;

using Evaluacion_2.Filters;

namespace Evaluacion_2.Controllers
{
    [AccesFilter]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
