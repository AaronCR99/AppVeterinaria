using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// importacion de libreria
using System.Net.Http;

namespace AppVeterinariaUCR.Data
{
    public class TipoCambioAPI
    {
        public HttpClient Inicial()
        {
            // se instancia un objeto HttpClient
            var client = new HttpClient();

            // aqui indicamos la direccion web donde esta la API
            client.BaseAddress = new Uri("http://apis.gometa.org");

            return client;
        }
    }
}
