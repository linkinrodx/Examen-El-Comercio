using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Conexion.BE;
using Conexion.DA;
using Microsoft.Extensions.Configuration;

namespace Conexion.BR
{
    public class BancoBR
    {
        private readonly ConexionBD _Coneccion;

        public BancoBR(IConfiguration configuration)
        {
            _Coneccion = new ConexionBD(configuration);
        }

        public List<BancoBE> GetBancos()
        {
            var listabancos = new List<BancoBE>();

            try
            {
                var reader = _Coneccion.GetTabla("select * from Banco");

                while (reader != null && reader.Read())
                {
                    var Banco = new BancoBE(reader);
                    listabancos.Add(Banco);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                listabancos = new List<BancoBE>();
            }

            return listabancos;
        }
    }
}
