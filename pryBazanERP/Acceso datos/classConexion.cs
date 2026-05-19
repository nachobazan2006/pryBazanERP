using System;
using System.Data.OleDb;
using System.IO;

namespace pryBazanERP.Conexión
{
    public class classConexion
    {
        private readonly string cadenaConexion;

        public classConexion()
        {
            string carpetaAplicacion = Path.GetDirectoryName(typeof(classConexion).Assembly.Location);
            string rutaBase = Path.Combine(carpetaAplicacion, "Acceso datos", "Bazan.accdb");
            cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" + rutaBase + ";Persist Security Info=False;";
        }

        public bool ProbarConexion()
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool ValidarUsuario(string mail, string contraseña)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT COUNT(*) FROM Usuario WHERE Mail = ? AND [Contraseña] = ?";

                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("?", mail);
                        comando.Parameters.AddWithValue("?", contraseña);

                        int cantidad = Convert.ToInt32(comando.ExecuteScalar());
                        return cantidad > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
