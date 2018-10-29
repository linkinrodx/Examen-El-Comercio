using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Conexion.BE;
using Conexion.DA;
using Microsoft.Extensions.Configuration;

namespace Conexion.BR
{
    public class SucursalBR
    {
        private readonly ConexionBD _Coneccion;

        public SucursalBR(IConfiguration configuration)
        {
            _Coneccion = new ConexionBD(configuration);
        }

        public List<SucursalBE> GetSucursalesbyIdBanco(int IdBanco)
        {
            var listasucursales = new List<SucursalBE>();

            try
            {
                var reader = _Coneccion.GetTabla("select * from Sucursal where IdBanco =" + IdBanco + " or " + IdBanco + "= 0");

                while (reader != null && reader.Read())
                {
                    var Sucursal = new SucursalBE(reader);
                    listasucursales.Add(Sucursal);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                listasucursales = new List<SucursalBE>();
            }

            return listasucursales;
        }
    }
}
