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
            string usuario;
            string perfil;
            return ObtenerDatosUsuario(mail, contraseña, out usuario, out perfil);
        }

        public bool ObtenerDatosUsuario(string mail, string contraseña, out string usuario, out string perfil)
        {
            usuario = "";
            perfil = "";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta =
                        "SELECT TOP 1 Usuario.Nombre, Usuario.Apellido, Perfil.Nombre AS NombrePerfil " +
                        "FROM (Usuario INNER JOIN [Usuario-Perfil] " +
                        "ON Usuario.Id_Usuario = CInt([Usuario-Perfil].Id_Usuario)) " +
                        "INNER JOIN Perfil " +
                        "ON Perfil.Id_Perfil = CInt([Usuario-Perfil].Id_Perfil) " +
                        "WHERE Usuario.Mail = ? AND Usuario.[Contraseña] = ?";

                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("?", mail);
                        comando.Parameters.AddWithValue("?", contraseña);

                        using (OleDbDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                usuario = lector["Nombre"].ToString() + " " + lector["Apellido"].ToString();
                                perfil = lector["NombrePerfil"].ToString();
                                return true;
                            }
                        }
                    }
                }
            }
            catch
            {
                return false;
            }

            return false;
        }
    }
}
