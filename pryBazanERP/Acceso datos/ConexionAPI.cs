using System.Net.Http;
using System.Threading.Tasks;

namespace pryBazanERP.Acceso_datos
{
    internal class ConexionAPI
    {
        private static readonly HttpClient cliente = new HttpClient();

        public async Task<string> ObtenerJsonAsync(string url)
        {
            HttpResponseMessage respuesta = await cliente.GetAsync(url);
            respuesta.EnsureSuccessStatusCode();
            return await respuesta.Content.ReadAsStringAsync();
        }
    }
}
