using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Conexion.BE;
using Conexion.DA;
using Microsoft.Extensions.Configuration;

namespace Conexion.BR
{
    public class UsuarioBR
    {
        private readonly ConexionBD _Coneccion;

        public UsuarioBR(IConfiguration configuration)
        {
            _Coneccion = new ConexionBD(configuration);
        }

        public UsuarioBE GetUsuarioByParametros(string nombre, string contrasenia)
        {
            UsuarioBE Usuario = null;

            try
            {
                var reader = _Coneccion.GetTabla("select * from Usuario where nombre ='" + nombre + "' and contrasenia='" + contrasenia + "'");

                while (reader != null && reader.Read())
                {
                    Usuario = new UsuarioBE(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Usuario = null;
            }

            return Usuario;
        }
    }
}
