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

        public void GrabarAuditoriaSesion(string usuario, string detalle)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "INSERT INTO AuditoriaSesion ([Fecha], [Hora], [Usuario], [Detalle]) VALUES (?, ?, ?, ?)";

                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        DateTime fechaHoraActual = DateTime.Now;

                        comando.Parameters.AddWithValue("?", fechaHoraActual.Date);
                        comando.Parameters.AddWithValue("?", fechaHoraActual.ToString("HH:mm:ss"));
                        comando.Parameters.AddWithValue("?", usuario);
                        comando.Parameters.AddWithValue("?", detalle);
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
            }
        }

        public bool GuardarContacto(string dniPersonal, string mail, string telefono, bool activo, string instagram, string facebook, string twitter, out string mensaje)
        {
            mensaje = "";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();

                    int idPersonal = ObtenerIdPersonalPorDni(conexion, dniPersonal);

                    if (idPersonal == 0)
                    {
                        mensaje = "No se encontro un personal con ese DNI.";
                        return false;
                    }

                    using (OleDbTransaction transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            int idContacto = InsertarContacto(conexion, transaccion, idPersonal, mail, telefono, activo);

                            InsertarRedSocial(conexion, transaccion, idContacto, "Instagram", instagram);
                            InsertarRedSocial(conexion, transaccion, idContacto, "Facebook", facebook);
                            InsertarRedSocial(conexion, transaccion, idContacto, "Twitter", twitter);

                            transaccion.Commit();
                            mensaje = "Contacto guardado correctamente.";
                            return true;
                        }
                        catch
                        {
                            transaccion.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "No se pudo guardar el contacto: " + ex.Message;
                return false;
            }
        }

        public bool GuardarPersonal(string dni, string apellido, string nombre, string direccion, string geo, string localidad, string provincia, bool activo, out string mensaje)
        {
            mensaje = "";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();

                    if (ObtenerIdPersonalPorDni(conexion, dni) != 0)
                    {
                        mensaje = "Ya existe un personal cargado con ese DNI.";
                        return false;
                    }

                    int idProvincia = ObtenerOCrearProvincia(conexion, provincia);
                    object idLocalidad = DBNull.Value;

                    if (provincia == "Cordoba" && !string.IsNullOrWhiteSpace(localidad))
                    {
                        idLocalidad = ObtenerOCrearLocalidad(conexion, localidad, idProvincia);
                    }

                    string consulta =
                        "INSERT INTO Personal (DNI, Apellido, Nombre, Direccion, Geo, Id_Localidad, Id_Provincia, Activo) " +
                        "VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("?", dni);
                        comando.Parameters.AddWithValue("?", apellido);
                        comando.Parameters.AddWithValue("?", nombre);
                        comando.Parameters.AddWithValue("?", direccion);
                        comando.Parameters.AddWithValue("?", geo);
                        comando.Parameters.AddWithValue("?", idLocalidad);
                        comando.Parameters.AddWithValue("?", idProvincia);
                        comando.Parameters.AddWithValue("?", activo);
                        comando.ExecuteNonQuery();
                    }

                    mensaje = "Personal guardado correctamente.";
                    return true;
                }
            }
            catch (Exception ex)
            {
                mensaje = "No se pudo guardar el personal: " + ex.Message;
                return false;
            }
        }

        private int ObtenerIdPersonalPorDni(OleDbConnection conexion, string dni)
        {
            using (OleDbCommand comando = new OleDbCommand("SELECT TOP 1 Id_Personal FROM Personal WHERE DNI = ?", conexion))
            {
                comando.Parameters.AddWithValue("?", dni);
                object resultado = comando.ExecuteScalar();

                if (resultado == null)
                {
                    return 0;
                }

                return Convert.ToInt32(resultado);
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

        private int ObtenerOCrearLocalidad(OleDbConnection conexion, string nombre, int idProvincia)
        {
            using (OleDbCommand comando = new OleDbCommand("SELECT TOP 1 Id_Localidad FROM Localidad WHERE Nombre = ? AND Id_Provincia = ?", conexion))
            {
                comando.Parameters.AddWithValue("?", nombre);
                comando.Parameters.AddWithValue("?", idProvincia);
                object resultado = comando.ExecuteScalar();

                if (resultado != null)
                {
                    return Convert.ToInt32(resultado);
                }
            }

            using (OleDbCommand comando = new OleDbCommand("INSERT INTO Localidad (Nombre, Id_Provincia) VALUES (?, ?)", conexion))
            {
                comando.Parameters.AddWithValue("?", nombre);
                comando.Parameters.AddWithValue("?", idProvincia);
                comando.ExecuteNonQuery();
            }

            using (OleDbCommand comando = new OleDbCommand("SELECT @@IDENTITY", conexion))
            {
                return Convert.ToInt32(comando.ExecuteScalar());
            }
        }

        private int InsertarContacto(OleDbConnection conexion, OleDbTransaction transaccion, int idPersonal, string mail, string telefono, bool activo)
        {
            using (OleDbCommand comando = new OleDbCommand("INSERT INTO Contacto (Id_Personal, Mail, Telefono, Redes, Activo) VALUES (?, ?, ?, ?, ?)", conexion, transaccion))
            {
                comando.Parameters.AddWithValue("?", idPersonal);
                comando.Parameters.AddWithValue("?", mail);
                comando.Parameters.AddWithValue("?", telefono);
                comando.Parameters.AddWithValue("?", "");
                comando.Parameters.AddWithValue("?", activo);
                comando.ExecuteNonQuery();
            }

            using (OleDbCommand comando = new OleDbCommand("SELECT @@IDENTITY", conexion, transaccion))
            {
                return Convert.ToInt32(comando.ExecuteScalar());
            }
        }

        private void InsertarRedSocial(OleDbConnection conexion, OleDbTransaction transaccion, int idContacto, string tipo, string usuarioUrl)
        {
            if (string.IsNullOrWhiteSpace(usuarioUrl))
            {
                return;
            }

            using (OleDbCommand comando = new OleDbCommand("INSERT INTO RedSocial (Id_Contacto, Tipo, UsuarioUrl) VALUES (?, ?, ?)", conexion, transaccion))
            {
                comando.Parameters.AddWithValue("?", idContacto);
                comando.Parameters.AddWithValue("?", tipo);
                comando.Parameters.AddWithValue("?", usuarioUrl.Trim());
                comando.ExecuteNonQuery();
            }
        }
    }
}
