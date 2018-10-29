using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Conexion.BE;
using Conexion.DA;
using Microsoft.Extensions.Configuration;

namespace Conexion.BR
{
    public class OrdenPagoBR
    {
        private readonly ConexionBD _Coneccion;

        public OrdenPagoBR(IConfiguration configuration)
        {
            _Coneccion = new ConexionBD(configuration);
        }

        public List<OrdenPagoBE> GetOrdenesPagobyIdSucursal(int IdSucursal, string moneda)
        {
            var listaOrdenesPago = new List<OrdenPagoBE>();

            try
            {
                string query = "select * from OrdenPago where (IdSucursal =" + IdSucursal + " or " + IdSucursal + "= 0)" + " and (moneda = '" + moneda + "' or '" + moneda + "' = '')";
                var reader = _Coneccion.GetTabla(query);

                while (reader != null && reader.Read())
                {
                    var OrdenPago = new OrdenPagoBE(reader);
                    listaOrdenesPago.Add(OrdenPago);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                listaOrdenesPago = new List<OrdenPagoBE>();
            }

            return listaOrdenesPago;
        }
    }
}
