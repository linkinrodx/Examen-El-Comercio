using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Net.Http;
using Newtonsoft.Json;
using Evaluacion_2.Models;
using Microsoft.Extensions.Configuration;

namespace Evaluacion_2.Services
{
    public class OrdenPagoService
    {
        private readonly IConfiguration _configuration;

        public OrdenPagoService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<List<OrdenPagoViewModel>> GetOrdenPagobyIdSucursal(int IdSucursal)
        {
            var data = new List<OrdenPagoViewModel>();

            using (HttpClient client = new HttpClient())
            {
                var uri = string.Concat(_configuration["Service:Url_API_Comercio"], "api/OrdenPago/GetOrdenesPagobyIdSucursal", "?IdSucursal=", IdSucursal.ToString());
                var response = await client.GetAsync(new Uri(uri).AbsoluteUri);
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<OrdenPagoViewModel>>(json);
            }

            return data;
        }
    }
}
