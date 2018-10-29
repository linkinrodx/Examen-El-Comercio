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
    public class SucursalService
    {
        private readonly IConfiguration _configuration;

        public SucursalService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<List<SucursalViewModel>> GetSucursalesbyIdBanco(int IdBanco)
        {
            var data = new List<SucursalViewModel>();

            using (HttpClient client = new HttpClient())
            {
                var uri = string.Concat(_configuration["Service:Url_API_Comercio"], "api/Sucursal/GetSucursalesbyIdBanco", "?IdBanco=", IdBanco.ToString());
                var response = await client.GetAsync(new Uri(uri).AbsoluteUri);
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<SucursalViewModel>>(json);
            }

            return data;
        }
    }
}
