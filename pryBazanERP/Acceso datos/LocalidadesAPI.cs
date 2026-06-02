using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace pryBazanERP.Acceso_datos
{
    internal class LocalidadesAPI
    {
        private const string UrlLocalidadesCordoba = "https://apis.datos.gob.ar/georef/api/localidades?provincia=cordoba&campos=id,nombre,provincia&max=5000";
        private readonly Dictionary<string, List<string>> busquedasCordoba = new Dictionary<string, List<string>>();
        private List<string> localidadesCordoba;
        private Task<List<string>> cargaLocalidadesCordoba;

        public Task PrecargarLocalidadesCordobaAsync()
        {
            return ObtenerLocalidadesCordobaAsync();
        }

        public async Task<List<string>> BuscarLocalidadesCordobaAsync(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto) || texto.Trim().Length < 2)
            {
                return new List<string>();
            }

            string textoNormalizado = texto.Trim().ToLower();

            if (busquedasCordoba.ContainsKey(textoNormalizado))
            {
                return new List<string>(busquedasCordoba[textoNormalizado]);
            }

            List<string> localidades = await ObtenerLocalidadesCordobaAsync();

            List<string> resultado = localidades
                .Where(l => l.IndexOf(textoNormalizado, StringComparison.OrdinalIgnoreCase) >= 0)
                .OrderBy(l => l.StartsWith(textoNormalizado, StringComparison.OrdinalIgnoreCase) ? 0 : 1)
                .ThenBy(l => l)
                .Take(10)
                .ToList();

            busquedasCordoba[textoNormalizado] = resultado;
            return new List<string>(resultado);
        }

        private Task<List<string>> ObtenerLocalidadesCordobaAsync()
        {
            if (localidadesCordoba != null)
            {
                return Task.FromResult(new List<string>(localidadesCordoba));
            }

            if (cargaLocalidadesCordoba == null)
            {
                cargaLocalidadesCordoba = CargarLocalidadesCordobaAsync();
            }

            return cargaLocalidadesCordoba;
        }

        private async Task<List<string>> CargarLocalidadesCordobaAsync()
        {
            List<string> localidades = ObtenerLocalidadesCordobaDesdeBase();

            if (localidades.Count == 0)
            {
                localidades = await ObtenerLocalidadesCordobaDesdeApiAsync();
                GuardarLocalidadesCordobaEnBase(localidades);
            }

            localidadesCordoba = localidades
                .Where(l => !string.IsNullOrWhiteSpace(l))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(l => l)
                .ToList();

            return new List<string>(localidadesCordoba);
        }

        private async Task<List<string>> ObtenerLocalidadesCordobaDesdeApiAsync()
        {
            ConexionAPI conexionAPI = new ConexionAPI();
            string json = await conexionAPI.ObtenerJsonAsync(UrlLocalidadesCordoba);

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            RespuestaLocalidades respuesta = serializador.Deserialize<RespuestaLocalidades>(json);

            if (respuesta == null || respuesta.localidades == null)
            {
                return new List<string>();
            }

            return respuesta.localidades
                .Where(l => l != null && !string.IsNullOrWhiteSpace(l.nombre))
                .Select(l => l.nombre.Trim())
                .ToList();
        }

        public async Task<int> ImportarLocalidadesCordobaAsync()
        {
            ConexionAPI conexionAPI = new ConexionAPI();
            string json = await conexionAPI.ObtenerJsonAsync(UrlLocalidadesCordoba);

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            RespuestaLocalidades respuesta = serializador.Deserialize<RespuestaLocalidades>(json);

            if (respuesta == null || respuesta.localidades == null)
            {
                return 0;
            }

            string carpetaAplicacion = Path.GetDirectoryName(typeof(LocalidadesAPI).Assembly.Location);
            string rutaBase = Path.Combine(carpetaAplicacion, "Acceso datos", "Bazan.accdb");
            string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" + rutaBase + ";Persist Security Info=False;";

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();
                int idProvincia = ObtenerOCrearProvincia(conexion, "Cordoba");
                int insertadas = 0;

                foreach (LocalidadGeoref localidad in respuesta.localidades)
                {
                    if (localidad == null || string.IsNullOrWhiteSpace(localidad.nombre))
                    {
                        continue;
                    }

                    if (!ExisteLocalidad(conexion, localidad.nombre, idProvincia))
                    {
                        InsertarLocalidad(conexion, localidad.nombre, idProvincia);
                        insertadas++;
                    }
                }

                return insertadas;
            }
        }

        private int ObtenerOCrearProvincia(OleDbConnection conexion, string nombre)
        {
            using (OleDbCommand comando = new OleDbCommand("SELECT TOP 1 Id_Provincia FROM Provincia WHERE Nombre = ?", conexion))
            {
                comando.Parameters.AddWithValue("?", nombre);
                object resultado = comando.ExecuteScalar();

                if (resultado != null)
                {
                    return Convert.ToInt32(resultado);
                }
            }

            using (OleDbCommand comando = new OleDbCommand("INSERT INTO Provincia (Nombre) VALUES (?)", conexion))
            {
                comando.Parameters.AddWithValue("?", nombre);
                comando.ExecuteNonQuery();
            }

            using (OleDbCommand comando = new OleDbCommand("SELECT @@IDENTITY", conexion))
            {
                return Convert.ToInt32(comando.ExecuteScalar());
            }
        }

        private bool ExisteLocalidad(OleDbConnection conexion, string nombre, int idProvincia)
        {
            using (OleDbCommand comando = new OleDbCommand("SELECT COUNT(*) FROM Localidad WHERE Nombre = ? AND Id_Provincia = ?", conexion))
            {
                comando.Parameters.AddWithValue("?", nombre);
                comando.Parameters.AddWithValue("?", idProvincia);
                return Convert.ToInt32(comando.ExecuteScalar()) > 0;
            }
        }

        private void InsertarLocalidad(OleDbConnection conexion, string nombre, int idProvincia)
        {
            using (OleDbCommand comando = new OleDbCommand("INSERT INTO Localidad (Nombre, Id_Provincia) VALUES (?, ?)", conexion))
            {
                comando.Parameters.AddWithValue("?", nombre);
                comando.Parameters.AddWithValue("?", idProvincia);
                comando.ExecuteNonQuery();
            }
        }

        private List<string> ObtenerLocalidadesCordobaDesdeBase()
        {
            List<string> localidades = new List<string>();
            string carpetaAplicacion = Path.GetDirectoryName(typeof(LocalidadesAPI).Assembly.Location);
            string rutaBase = Path.Combine(carpetaAplicacion, "Acceso datos", "Bazan.accdb");
            string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" + rutaBase + ";Persist Security Info=False;";

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();

                string consulta =
                    "SELECT Localidad.Nombre " +
                    "FROM Localidad INNER JOIN Provincia ON Localidad.Id_Provincia = Provincia.Id_Provincia " +
                    "WHERE Provincia.Nombre = ? " +
                    "ORDER BY Localidad.Nombre";

                using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("?", "Cordoba");

                    using (OleDbDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            localidades.Add(lector["Nombre"].ToString());
                        }
                    }
                }
            }

            return localidades;
        }

        private void GuardarLocalidadesCordobaEnBase(List<string> localidades)
        {
            if (localidades.Count == 0)
            {
                return;
            }

            string carpetaAplicacion = Path.GetDirectoryName(typeof(LocalidadesAPI).Assembly.Location);
            string rutaBase = Path.Combine(carpetaAplicacion, "Acceso datos", "Bazan.accdb");
            string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" + rutaBase + ";Persist Security Info=False;";

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();
                int idProvincia = ObtenerOCrearProvincia(conexion, "Cordoba");

                foreach (string localidad in localidades)
                {
                    if (!ExisteLocalidad(conexion, localidad, idProvincia))
                    {
                        InsertarLocalidad(conexion, localidad, idProvincia);
                    }
                }
            }
        }

        private class RespuestaLocalidades
        {
            public int cantidad { get; set; }
            public int total { get; set; }
            public List<LocalidadGeoref> localidades { get; set; }
        }

        private class LocalidadGeoref
        {
            public string id { get; set; }
            public string nombre { get; set; }
        }
    }
}
