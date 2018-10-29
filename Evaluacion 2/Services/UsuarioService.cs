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
    public class UsuarioService
    {
        private readonly IConfiguration _configuration;

        public UsuarioService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<UsuarioViewModel> GetUsuarioByParametros(string nombre, string contrasenia)
        {
            UsuarioViewModel data = null;

            using (HttpClient client = new HttpClient())
            {
                var uri = string.Concat(_configuration["Service:Url_API_Comercio"], "api/Usuario/GetUsuarioByParametros", "?nombre=", nombre, "&contrasenia=", contrasenia);
                var response = await client.GetAsync(new Uri(uri).AbsoluteUri);
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<UsuarioViewModel>(json);
            }

            return data;
        }
    }
}
