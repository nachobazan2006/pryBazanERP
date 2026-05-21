using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace pryBazanERP.Acceso_datos
{
    internal class LocalidadesAPI
    {
        private const string UrlLocalidadesCordoba = "https://apis.datos.gob.ar/georef/api/localidades?provincia=cordoba&campos=id,nombre,provincia&max=5000";

        public async Task<List<string>> BuscarLocalidadesCordobaAsync(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto) || texto.Trim().Length < 2)
            {
                return new List<string>();
            }

            string url = "https://apis.datos.gob.ar/georef/api/localidades?provincia=cordoba&nombre=" +
                Uri.EscapeDataString(texto.Trim()) +
                "&campos=id,nombre,provincia&max=10";

            ConexionAPI conexionAPI = new ConexionAPI();
            string json = await conexionAPI.ObtenerJsonAsync(url);

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            RespuestaLocalidades respuesta = serializador.Deserialize<RespuestaLocalidades>(json);
            List<string> localidades = new List<string>();

            if (respuesta == null || respuesta.localidades == null)
            {
                return localidades;
            }

            foreach (LocalidadGeoref localidad in respuesta.localidades)
            {
                if (localidad != null && !string.IsNullOrWhiteSpace(localidad.nombre))
                {
                    localidades.Add(localidad.nombre);
                }
            }

            return localidades;
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
