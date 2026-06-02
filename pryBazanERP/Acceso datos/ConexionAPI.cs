using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System;

namespace pryBazanERP.Acceso_datos
{
    internal class ConexionAPI
    {
        private static readonly HttpClient cliente = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(8)
        };

        public async Task<string> ObtenerJsonAsync(string url)
        {
            HttpResponseMessage respuesta = await cliente.GetAsync(url);
            respuesta.EnsureSuccessStatusCode();
            byte[] contenido = await respuesta.Content.ReadAsByteArrayAsync();
            return Encoding.UTF8.GetString(contenido);
        }
    }
}
