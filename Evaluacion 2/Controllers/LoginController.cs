using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Evaluacion_2.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;

namespace Evaluacion_2.Controllers
{
    public class LoginController : Controller
    {
        public readonly UsuarioService _UsuarioService;
        private readonly IConfiguration _configuration;

        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
            _UsuarioService = new UsuarioService(_configuration);
        }

        [HttpGet]
        public IActionResult Index()
        {
            Response.Cookies.Delete("UsuarioId");
            Response.Cookies.Delete("UsuarioNombre");
            Response.Cookies.Delete("UsuarioRolId");

            ViewBag.showSalir = false;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Acceso(string usuario, string contrasenia)
        {
            var Usuario = await Task.Run(() => _UsuarioService.GetUsuarioByParametros(usuario, contrasenia));

            if (Usuario != null)
            {
                CookieOptions options = new CookieOptions
                {
                    Expires = DateTime.Now.AddMinutes(5)
                };

                Response.Cookies.Append("UsuarioId", Usuario.IdUsuario.ToString(), options);
                Response.Cookies.Append("UsuarioNombre", Usuario.Nombre, options);
                Response.Cookies.Append("UsuarioRolId", Usuario.RolId.ToString(), options);
                
                return RedirectToAction("index", "home");
            }
            else
            {
                return RedirectToAction("index", "Login");
            }
        }

        public ActionResult Salir(string usuario, string contrasenia)
        {
            Response.Cookies.Delete("UsuarioId");
            Response.Cookies.Delete("UsuarioNombre");
            Response.Cookies.Delete("UsuarioRolId");

            return RedirectToAction("index", "login");
        }
    }
}