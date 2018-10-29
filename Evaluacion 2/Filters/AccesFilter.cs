using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;

namespace Evaluacion_2.Filters
{
    public class AccesFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var UsuarioId = context.HttpContext.Request.Cookies["UsuarioId"];
            var UsuarioNombre = context.HttpContext.Request.Cookies["UsuarioNombre"];
            var UsuarioRolId = context.HttpContext.Request.Cookies["UsuarioRolId"];

            if (UsuarioId != null)
            {
                CookieOptions options = new CookieOptions
                {
                    Expires = DateTime.Now.AddMinutes(5)
                };

                context.HttpContext.Response.Cookies.Append("UsuarioId", UsuarioId, options);
                context.HttpContext.Response.Cookies.Append("UsuarioNombre", UsuarioNombre, options);
                context.HttpContext.Response.Cookies.Append("UsuarioRolId", UsuarioRolId, options);

                var RutaDestino = context.HttpContext.Request.Path.ToString();

                if (RutaDestino.Contains("Banco") && !(UsuarioRolId == "1" || UsuarioRolId == "2"))
                {
                    context.HttpContext.Response.Redirect("./home");
                }
                else if (RutaDestino.Contains("Sucursal") && !(UsuarioRolId == "1" || UsuarioRolId == "2"))
                {
                    context.HttpContext.Response.Redirect("./home");
                }
                else if (RutaDestino.Contains("OrdenPago") && !(UsuarioRolId == "1" || UsuarioRolId == "3"))
                {
                    context.HttpContext.Response.Redirect("./home");
                }
            }
            else
            {
                context.HttpContext.Response.Redirect("./Login");
            }
        }
    }
}
