using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace pryBazanERP.Conexión
{
    public class classConexion
    {
        private readonly string cadenaConexion;

        public class PersonalItem
        {
            public int IdPersonal { get; set; }
            public string DNI { get; set; }
            public string Apellido { get; set; }
            public string Nombre { get; set; }

            public string Descripcion
            {
                get { return DNI + " - " + Apellido + ", " + Nombre; }
            }
        }

        public class PersonalDetalle
        {
            public int IdPersonal { get; set; }
            public string DNI { get; set; }
            public string Apellido { get; set; }
            public string Nombre { get; set; }
            public string Direccion { get; set; }
            public string Geo { get; set; }
            public string Localidad { get; set; }
            public string Provincia { get; set; }
            public bool Activo { get; set; }
        }

        public class ContactoItem
        {
            public int IdContacto { get; set; }
            public string Medio { get; set; }
            public string Uso { get; set; }
            public string Dato { get; set; }
            public string Enlace { get; set; }
        }

        public class RedItem
        {
            public int IdRed { get; set; }
            public string Nombre { get; set; }
        }

        public class AuditoriaItem
        {
            public int IdAuditoria { get; set; }
            public DateTime Fecha { get; set; }
            public string Hora { get; set; }
            public string Usuario { get; set; }
            public string Perfil { get; set; }
            public string Detalle { get; set; }
        }

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
            int idUsuario;
            int idPersonal;
            return ObtenerDatosUsuario(mail, contraseña, out usuario, out perfil, out idUsuario, out idPersonal);
        }

        public bool ObtenerDatosUsuario(string mail, string contraseña, out string usuario, out string perfil, out int idUsuario, out int idPersonal)
        {
            usuario = "";
            perfil = "";
            idUsuario = 0;
            idPersonal = 0;

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta =
                        "SELECT TOP 1 Usuario.Id_Usuario, Usuario.Id_Personal, Usuario.Nombre, Usuario.Apellido, Perfil.Nombre AS NombrePerfil " +
                        "FROM (Usuario INNER JOIN [Usuario-Perfil] " +
                        "ON Usuario.Id_Usuario = CInt([Usuario-Perfil].Id_Usuario)) " +
                        "INNER JOIN Perfil " +
                        "ON Perfil.Id_Perfil = CInt([Usuario-Perfil].Id_Perfil) " +
                        "WHERE Usuario.Mail = ?";

                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("?", mail);

                        using (OleDbDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                string contrasenaPersistida = ObtenerContrasenaPersistida(conexion, mail);
                                if (!VerificarContrasenaPersistida(contrasenaPersistida, contraseña))
                                {
                                    return false;
                                }

                                idUsuario = Convert.ToInt32(lector["Id_Usuario"]);

                                if (lector["Id_Personal"] != DBNull.Value)
                                {
                                    idPersonal = Convert.ToInt32(lector["Id_Personal"]);
                                }

                                usuario = lector["Nombre"].ToString() + " " + lector["Apellido"].ToString();
                                perfil = ObtenerPerfilesUsuario(conexion, idUsuario);

                                if (string.IsNullOrWhiteSpace(perfil))
                                {
                                    perfil = lector["NombrePerfil"].ToString();
                                }

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

        public List<AuditoriaItem> ObtenerAuditoriaSesion()
        {
            List<AuditoriaItem> auditorias = new List<AuditoriaItem>();

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();

                string consulta =
                    "SELECT Id_Auditoria, Fecha, Hora, Usuario, Detalle " +
                    "FROM AuditoriaSesion " +
                    "ORDER BY Id_Auditoria DESC";

                using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                using (OleDbDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        auditorias.Add(new AuditoriaItem
                        {
                            IdAuditoria = Convert.ToInt32(lector["Id_Auditoria"]),
                            Fecha = lector["Fecha"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(lector["Fecha"]),
                            Hora = lector["Hora"].ToString(),
                            Usuario = lector["Usuario"].ToString(),
                            Perfil = ObtenerPerfilesPorUsuario(conexion, lector["Usuario"].ToString()),
                            Detalle = lector["Detalle"].ToString()
                        });
                    }
                }
            }

            return auditorias;
        }

        public bool GuardarContacto(int idPersonal, string medio, string uso, string dato, out string mensaje)
        {
            return GuardarContacto(idPersonal, medio, uso, dato, "", out mensaje);
        }

        public bool GuardarContacto(int idPersonal, string medio, string uso, string dato, string enlace, out string mensaje)
        {
            mensaje = "";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();
                    AsegurarTablaContacto(conexion);

                    if (idPersonal == 0)
                    {
                        mensaje = "No hay un personal asociado a la sesion.";
                        return false;
                    }

                    if (ExisteContacto(conexion, idPersonal, medio, uso, dato, enlace))
                    {
                        mensaje = "Ese contacto ya esta cargado para la persona actual.";
                        return false;
                    }

                    using (OleDbTransaction transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            InsertarContacto(conexion, transaccion, idPersonal, medio, uso, dato, enlace);
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

        public List<ContactoItem> ObtenerContactosPorPersonal(int idPersonal)
        {
            List<ContactoItem> contactos = new List<ContactoItem>();

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();
                AsegurarTablaContacto(conexion);

                string consulta =
                    "SELECT Id_Contacto, Medio, Uso, Dato, Enlace FROM Contacto " +
                    "WHERE Id_Personal = ? AND Activo = ? " +
                    "ORDER BY Uso, Medio, Dato";

                using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("?", idPersonal);
                    comando.Parameters.AddWithValue("?", true);

                    using (OleDbDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            contactos.Add(new ContactoItem
                            {
                                IdContacto = Convert.ToInt32(lector["Id_Contacto"]),
                                Medio = lector["Medio"].ToString(),
                                Uso = lector["Uso"].ToString(),
                                Dato = lector["Dato"].ToString(),
                                Enlace = lector["Enlace"].ToString()
                            });
                        }
                    }
                }
            }

            return contactos;
        }

        public bool GuardarPersonal(string dni, string apellido, string nombre, string direccion, string geo, string localidad, string provincia, bool activo, out string mensaje)
        {
            int idPersonal;
            return GuardarPersonal(dni, apellido, nombre, direccion, geo, localidad, provincia, activo, out mensaje, out idPersonal);
        }

        public bool GuardarPersonal(string dni, string apellido, string nombre, string direccion, string geo, string localidad, string provincia, bool activo, out string mensaje, out int idPersonal)
        {
            mensaje = "";
            idPersonal = 0;

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
                    object idLocalidad = ObtenerIdLocalidadParaPersonal(conexion, provincia, localidad, idProvincia);

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

                    using (OleDbCommand comando = new OleDbCommand("SELECT @@IDENTITY", conexion))
                    {
                        idPersonal = Convert.ToInt32(comando.ExecuteScalar());
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

        public bool AsociarUsuarioPersonal(int idUsuario, int idPersonal, out string mensaje)
        {
            mensaje = "";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();

                    using (OleDbCommand comando = new OleDbCommand("UPDATE Usuario SET Id_Personal = ? WHERE Id_Usuario = ?", conexion))
                    {
                        comando.Parameters.AddWithValue("?", idPersonal);
                        comando.Parameters.AddWithValue("?", idUsuario);
                        comando.ExecuteNonQuery();
                    }
                }

                mensaje = "Usuario asociado al personal correctamente.";
                return true;
            }
            catch (Exception ex)
            {
                mensaje = "No se pudo asociar el usuario al personal: " + ex.Message;
                return false;
            }
        }

        public bool ActualizarPersonal(int idPersonal, string dni, string apellido, string nombre, string direccion, string geo, string localidad, string provincia, bool activo, out string mensaje)
        {
            mensaje = "";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();

                    int idProvincia = ObtenerOCrearProvincia(conexion, provincia);
                    object idLocalidad = ObtenerIdLocalidadParaPersonal(conexion, provincia, localidad, idProvincia);

                    string consulta =
                        "UPDATE Personal SET DNI = ?, Apellido = ?, Nombre = ?, Direccion = ?, Geo = ?, Id_Localidad = ?, Id_Provincia = ?, Activo = ? " +
                        "WHERE Id_Personal = ?";

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
                        comando.Parameters.AddWithValue("?", idPersonal);
                        comando.ExecuteNonQuery();
                    }

                    mensaje = "Personal actualizado correctamente.";
                    return true;
                }
            }
            catch (Exception ex)
            {
                mensaje = "No se pudo actualizar el personal: " + ex.Message;
                return false;
            }
        }

        public PersonalDetalle ObtenerPersonalDetalle(int idPersonal)
        {
            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();

                string consulta =
                    "SELECT Personal.Id_Personal, Personal.DNI, Personal.Apellido, Personal.Nombre, Personal.Direccion, Personal.Geo, Personal.Activo, " +
                    "Localidad.Nombre AS NombreLocalidad, Provincia.Nombre AS NombreProvincia " +
                    "FROM (Personal LEFT JOIN Localidad ON Personal.Id_Localidad = Localidad.Id_Localidad) " +
                    "LEFT JOIN Provincia ON Personal.Id_Provincia = Provincia.Id_Provincia " +
                    "WHERE Personal.Id_Personal = ?";

                using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("?", idPersonal);

                    using (OleDbDataReader lector = comando.ExecuteReader())
                    {
                        if (!lector.Read())
                        {
                            return null;
                        }

                        return new PersonalDetalle
                        {
                            IdPersonal = Convert.ToInt32(lector["Id_Personal"]),
                            DNI = lector["DNI"].ToString(),
                            Apellido = lector["Apellido"].ToString(),
                            Nombre = lector["Nombre"].ToString(),
                            Direccion = lector["Direccion"].ToString(),
                            Geo = lector["Geo"].ToString(),
                            Localidad = lector["NombreLocalidad"].ToString(),
                            Provincia = lector["NombreProvincia"].ToString(),
                            Activo = lector["Activo"] != DBNull.Value && Convert.ToBoolean(lector["Activo"])
                        };
                    }
                }
            }
        }

        public List<PersonalItem> ObtenerPersonalItems()
        {
            List<PersonalItem> personal = new List<PersonalItem>();

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();

                string consulta = "SELECT Id_Personal, DNI, Apellido, Nombre FROM Personal ORDER BY Apellido, Nombre";

                using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                using (OleDbDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        personal.Add(new PersonalItem
                        {
                            IdPersonal = Convert.ToInt32(lector["Id_Personal"]),
                            DNI = lector["DNI"].ToString(),
                            Apellido = lector["Apellido"].ToString(),
                            Nombre = lector["Nombre"].ToString()
                        });
                    }
                }
            }

            return personal;
        }

        public List<RedItem> ObtenerRedes()
        {
            List<RedItem> redes = new List<RedItem>();

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();
                AsegurarTablaRedes(conexion);

                string consulta = "SELECT Id_Red, Nombre FROM Redes ORDER BY Nombre";

                using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                using (OleDbDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        redes.Add(new RedItem
                        {
                            IdRed = Convert.ToInt32(lector["Id_Red"]),
                            Nombre = lector["Nombre"].ToString()
                        });
                    }
                }
            }

            return redes;
        }

        public bool CambiarContrasena(int idUsuario, string contrasenaActual, string contrasenaNueva, out string mensaje)
        {
            mensaje = "";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();

                    using (OleDbCommand comando = new OleDbCommand("SELECT [Contraseña] FROM Usuario WHERE Id_Usuario = ?", conexion))
                    {
                        comando.Parameters.AddWithValue("?", idUsuario);
                        object resultado = comando.ExecuteScalar();

                        if (resultado == null)
                        {
                            mensaje = "No se encontro el usuario.";
                            return false;
                        }

                        if (!VerificarContrasenaPersistida(resultado.ToString(), contrasenaActual))
                        {
                            mensaje = "La contrasena actual no es correcta.";
                            return false;
                        }
                    }

                    using (OleDbCommand comando = new OleDbCommand("UPDATE Usuario SET [Contraseña] = ? WHERE Id_Usuario = ?", conexion))
                    {
                        comando.Parameters.AddWithValue("?", CodificarContrasena(contrasenaNueva));
                        comando.Parameters.AddWithValue("?", idUsuario);
                        comando.ExecuteNonQuery();
                    }

                    mensaje = "Contrasena actualizada correctamente.";
                    return true;
                }
            }
            catch (Exception ex)
            {
                mensaje = "No se pudo cambiar la contrasena: " + ex.Message;
                return false;
            }
        }

        public string ObtenerNombreUsuarioDisponible(string nombreBase)
        {
            string usuario = nombreBase;
            int numero = 2;

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();

                while (ExisteUsuario(conexion, usuario))
                {
                    usuario = nombreBase + numero.ToString();
                    numero++;
                }
            }

            return usuario;
        }

        public bool GuardarUsuarioGenerado(string nombre, string apellido, string usuario, string contrasena, out string mensaje)
        {
            return GuardarUsuarioGenerado(nombre, apellido, usuario, contrasena, "Lector", out mensaje);
        }

        public bool GuardarUsuarioGenerado(string nombre, string apellido, string usuario, string contrasena, string perfil, out string mensaje)
        {
            mensaje = "";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();

                    if (ExisteUsuario(conexion, usuario))
                    {
                        mensaje = "Ya existe un usuario con ese nombre de acceso.";
                        return false;
                    }

                    int idPerfil = ObtenerIdPerfil(conexion, string.IsNullOrWhiteSpace(perfil) ? "Lector" : perfil.Trim());

                    using (OleDbTransaction transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            int idUsuario = InsertarUsuario(conexion, transaccion, nombre, apellido, usuario, contrasena);
                            InsertarUsuarioPerfil(conexion, transaccion, idUsuario, idPerfil);
                            transaccion.Commit();

                            mensaje = "Usuario generado correctamente. Entregale el usuario y la contrasena inicial, y pedile que la cambie al ingresar.";
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
                mensaje = "No se pudo generar el usuario: " + ex.Message;
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

        private bool ExisteUsuario(OleDbConnection conexion, string usuario)
        {
            using (OleDbCommand comando = new OleDbCommand("SELECT COUNT(*) FROM Usuario WHERE Mail = ?", conexion))
            {
                comando.Parameters.AddWithValue("?", usuario);
                return Convert.ToInt32(comando.ExecuteScalar()) > 0;
            }
        }

        private string ObtenerPerfilesUsuario(OleDbConnection conexion, int idUsuario)
        {
            List<string> perfiles = new List<string>();

            string consulta =
                "SELECT Perfil.Nombre FROM [Usuario-Perfil] " +
                "INNER JOIN Perfil ON Perfil.Id_Perfil = CInt([Usuario-Perfil].Id_Perfil) " +
                "WHERE CInt([Usuario-Perfil].Id_Usuario) = ? " +
                "ORDER BY Perfil.Id_Perfil";

            using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("?", idUsuario);

                using (OleDbDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        perfiles.Add(lector["Nombre"].ToString());
                    }
                }
            }

            return string.Join(", ", perfiles);
        }

        private string ObtenerPerfilesPorUsuario(OleDbConnection conexion, string usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario))
            {
                return "";
            }

            object idUsuario;

            using (OleDbCommand comando = new OleDbCommand("SELECT TOP 1 Id_Usuario FROM Usuario WHERE Mail = ?", conexion))
            {
                comando.Parameters.AddWithValue("?", usuario);
                idUsuario = comando.ExecuteScalar();
            }

            if (idUsuario == null)
            {
                return "";
            }

            return ObtenerPerfilesUsuario(conexion, Convert.ToInt32(idUsuario));
        }

        public string ObtenerNombreCompletoUsuarioPorMail(string mail)
        {
            if (string.IsNullOrWhiteSpace(mail))
            {
                return "";
            }

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();

                using (OleDbCommand comando = new OleDbCommand("SELECT TOP 1 Nombre, Apellido FROM Usuario WHERE Mail = ?", conexion))
                {
                    comando.Parameters.AddWithValue("?", mail);

                    using (OleDbDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            return lector["Nombre"].ToString() + " " + lector["Apellido"].ToString();
                        }
                    }
                }
            }

            return mail;
        }

        private int ObtenerIdPerfil(OleDbConnection conexion, string nombrePerfil)
        {
            using (OleDbCommand comando = new OleDbCommand("SELECT TOP 1 Id_Perfil FROM Perfil WHERE Nombre = ?", conexion))
            {
                comando.Parameters.AddWithValue("?", nombrePerfil);
                object resultado = comando.ExecuteScalar();

                if (resultado != null)
                {
                    return Convert.ToInt32(resultado);
                }
            }

            using (OleDbCommand comando = new OleDbCommand("INSERT INTO Perfil (Nombre) VALUES (?)", conexion))
            {
                comando.Parameters.AddWithValue("?", nombrePerfil);
                comando.ExecuteNonQuery();
            }

            using (OleDbCommand comando = new OleDbCommand("SELECT @@IDENTITY", conexion))
            {
                return Convert.ToInt32(comando.ExecuteScalar());
            }
        }

        public List<string> ObtenerPerfilesDisponibles()
        {
            List<string> perfiles = new List<string>();

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();

                using (OleDbCommand comando = new OleDbCommand("SELECT Nombre FROM Perfil ORDER BY Nombre", conexion))
                using (OleDbDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        perfiles.Add(lector["Nombre"].ToString());
                    }
                }
            }

            if (perfiles.Count == 0)
            {
                perfiles.Add("Lector");
                perfiles.Add("Administrador");
            }

            return perfiles;
        }

        private int InsertarUsuario(OleDbConnection conexion, OleDbTransaction transaccion, string nombre, string apellido, string usuario, string contrasena)
        {
            using (OleDbCommand comando = new OleDbCommand("INSERT INTO Usuario (Nombre, Apellido, Mail, [Contraseña]) VALUES (?, ?, ?, ?)", conexion, transaccion))
            {
                comando.Parameters.AddWithValue("?", nombre);
                comando.Parameters.AddWithValue("?", apellido);
                comando.Parameters.AddWithValue("?", usuario);
                comando.Parameters.AddWithValue("?", CodificarContrasena(contrasena));
                comando.ExecuteNonQuery();
            }

            using (OleDbCommand comando = new OleDbCommand("SELECT @@IDENTITY", conexion, transaccion))
            {
                return Convert.ToInt32(comando.ExecuteScalar());
            }
        }

        private void InsertarUsuarioPerfil(OleDbConnection conexion, OleDbTransaction transaccion, int idUsuario, int idPerfil)
        {
            using (OleDbCommand comando = new OleDbCommand("INSERT INTO [Usuario-Perfil] (Id_Usuario, Id_Perfil) VALUES (?, ?)", conexion, transaccion))
            {
                comando.Parameters.AddWithValue("?", idUsuario.ToString());
                comando.Parameters.AddWithValue("?", idPerfil.ToString());
                comando.ExecuteNonQuery();
            }
        }

        public string ObtenerRutaBaseDatos()
        {
            string prefijo = "Data Source=";
            int inicio = cadenaConexion.IndexOf(prefijo, StringComparison.OrdinalIgnoreCase);

            if (inicio < 0)
            {
                return "";
            }

            inicio += prefijo.Length;
            int fin = cadenaConexion.IndexOf(';', inicio);

            if (fin < 0)
            {
                fin = cadenaConexion.Length;
            }

            return cadenaConexion.Substring(inicio, fin - inicio);
        }

        private string ObtenerContrasenaPersistida(OleDbConnection conexion, string mail)
        {
            using (OleDbCommand comando = new OleDbCommand("SELECT TOP 1 [Contraseña] FROM Usuario WHERE Mail = ?", conexion))
            {
                comando.Parameters.AddWithValue("?", mail);
                object resultado = comando.ExecuteScalar();
                return resultado == null || resultado == DBNull.Value ? "" : resultado.ToString();
            }
        }

        private bool VerificarContrasenaPersistida(string contrasenaPersistida, string contrasenaIngresada)
        {
            if (string.IsNullOrWhiteSpace(contrasenaPersistida))
            {
                return false;
            }

            if (contrasenaPersistida.StartsWith("sha256$", StringComparison.OrdinalIgnoreCase))
            {
                string[] partes = contrasenaPersistida.Split('$');
                if (partes.Length != 3)
                {
                    return false;
                }

                string salt = partes[1];
                string hashEsperado = partes[2];
                string hashIngresado = CalcularSha256(salt + contrasenaIngresada);
                return string.Equals(hashEsperado, hashIngresado, StringComparison.OrdinalIgnoreCase);
            }

            return string.Equals(contrasenaPersistida, contrasenaIngresada, StringComparison.Ordinal);
        }

        private string CodificarContrasena(string contrasena)
        {
            string salt = Guid.NewGuid().ToString("N");
            string hash = CalcularSha256(salt + contrasena);
            return "sha256$" + salt + "$" + hash;
        }

        private string CalcularSha256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(texto);
                byte[] hash = sha256.ComputeHash(bytes);
                StringBuilder sb = new StringBuilder(hash.Length * 2);

                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }

                return sb.ToString();
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

        private object ObtenerIdLocalidadParaPersonal(OleDbConnection conexion, string provincia, string localidad, int idProvincia)
        {
            if (provincia == "Cordoba" && !string.IsNullOrWhiteSpace(localidad))
            {
                return ObtenerOCrearLocalidad(conexion, localidad, idProvincia);
            }

            return DBNull.Value;
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

        private void AsegurarTablaContacto(OleDbConnection conexion)
        {
            AgregarColumnaSiNoExiste(conexion, "Contacto", "Medio", "TEXT(20)");
            AgregarColumnaSiNoExiste(conexion, "Contacto", "Uso", "TEXT(20)");
            AgregarColumnaSiNoExiste(conexion, "Contacto", "Dato", "TEXT(255)");
            AgregarColumnaSiNoExiste(conexion, "Contacto", "Enlace", "TEXT(255)");
            MigrarContactosAnteriores(conexion);
        }

        private void AgregarColumnaSiNoExiste(OleDbConnection conexion, string tabla, string columna, string definicion)
        {
            using (System.Data.DataTable columnas = conexion.GetSchema("Columns"))
            {
                foreach (System.Data.DataRow fila in columnas.Rows)
                {
                    if (fila["TABLE_NAME"].ToString().Equals(tabla, StringComparison.OrdinalIgnoreCase) &&
                        fila["COLUMN_NAME"].ToString().Equals(columna, StringComparison.OrdinalIgnoreCase))
                    {
                        return;
                    }
                }
            }

            using (OleDbCommand comando = new OleDbCommand("ALTER TABLE " + tabla + " ADD COLUMN " + columna + " " + definicion, conexion))
            {
                comando.ExecuteNonQuery();
            }
        }

        private void MigrarContactosAnteriores(OleDbConnection conexion)
        {
            using (OleDbCommand comando = new OleDbCommand("UPDATE Contacto SET Medio = ?, Uso = ?, Dato = Mail WHERE (Dato IS NULL OR Dato = '') AND Mail IS NOT NULL AND Mail <> ''", conexion))
            {
                comando.Parameters.AddWithValue("?", "Mail");
                comando.Parameters.AddWithValue("?", "Principal");
                comando.ExecuteNonQuery();
            }

            using (OleDbCommand comando = new OleDbCommand("UPDATE Contacto SET Medio = ?, Uso = ?, Dato = Telefono WHERE (Dato IS NULL OR Dato = '') AND Telefono IS NOT NULL AND Telefono <> ''", conexion))
            {
                comando.Parameters.AddWithValue("?", "Telefono");
                comando.Parameters.AddWithValue("?", "Principal");
                comando.ExecuteNonQuery();
            }
        }

        private bool ExisteContacto(OleDbConnection conexion, int idPersonal, string medio, string uso, string dato, string enlace)
        {
            using (OleDbCommand comando = new OleDbCommand("SELECT COUNT(*) FROM Contacto WHERE Id_Personal = ? AND Medio = ? AND Uso = ? AND Dato = ? AND Enlace = ? AND Activo = ?", conexion))
            {
                comando.Parameters.AddWithValue("?", idPersonal);
                comando.Parameters.AddWithValue("?", medio);
                comando.Parameters.AddWithValue("?", uso);
                comando.Parameters.AddWithValue("?", dato);
                comando.Parameters.AddWithValue("?", enlace);
                comando.Parameters.AddWithValue("?", true);
                return Convert.ToInt32(comando.ExecuteScalar()) > 0;
            }
        }

        private int InsertarContacto(OleDbConnection conexion, OleDbTransaction transaccion, int idPersonal, string medio, string uso, string dato, string enlace)
        {
            using (OleDbCommand comando = new OleDbCommand("INSERT INTO Contacto (Id_Personal, Mail, Telefono, Redes, Activo, Medio, Uso, Dato, Enlace) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)", conexion, transaccion))
            {
                comando.Parameters.AddWithValue("?", idPersonal);
                comando.Parameters.AddWithValue("?", medio == "Mail" ? dato : "");
                comando.Parameters.AddWithValue("?", medio == "Telefono" ? dato : "");
                comando.Parameters.AddWithValue("?", medio == "Red social" ? dato : "");
                comando.Parameters.AddWithValue("?", true);
                comando.Parameters.AddWithValue("?", medio);
                comando.Parameters.AddWithValue("?", uso);
                comando.Parameters.AddWithValue("?", dato);
                comando.Parameters.AddWithValue("?", enlace);
                comando.ExecuteNonQuery();
            }

            using (OleDbCommand comando = new OleDbCommand("SELECT @@IDENTITY", conexion, transaccion))
            {
                return Convert.ToInt32(comando.ExecuteScalar());
            }
        }

        private void AsegurarTablaRedes(OleDbConnection conexion)
        {
            bool existeTabla = false;

            using (System.Data.DataTable tablas = conexion.GetSchema("Tables"))
            {
                foreach (System.Data.DataRow tabla in tablas.Rows)
                {
                    if (tabla["TABLE_NAME"].ToString().Equals("Redes", StringComparison.OrdinalIgnoreCase))
                    {
                        existeTabla = true;
                        break;
                    }
                }
            }

            if (!existeTabla)
            {
                using (OleDbCommand comando = new OleDbCommand("CREATE TABLE Redes (Id_Red AUTOINCREMENT PRIMARY KEY, Nombre TEXT(50) NOT NULL)", conexion))
                {
                    comando.ExecuteNonQuery();
                }

                using (OleDbCommand comando = new OleDbCommand("CREATE UNIQUE INDEX UX_Redes_Nombre ON Redes (Nombre)", conexion))
                {
                    comando.ExecuteNonQuery();
                }
            }

            InsertarRedSiNoExiste(conexion, "Instagram");
            InsertarRedSiNoExiste(conexion, "Tik Tok");
            InsertarRedSiNoExiste(conexion, "Twitter");
            InsertarRedSiNoExiste(conexion, "Facebook");
            InsertarRedSiNoExiste(conexion, "LinkedIn");
        }

        private void InsertarRedSiNoExiste(OleDbConnection conexion, string nombre)
        {
            using (OleDbCommand comando = new OleDbCommand("SELECT TOP 1 Id_Red FROM Redes WHERE Nombre = ?", conexion))
            {
                comando.Parameters.AddWithValue("?", nombre);

                if (comando.ExecuteScalar() != null)
                {
                    return;
                }
            }

            using (OleDbCommand comando = new OleDbCommand("INSERT INTO Redes (Nombre) VALUES (?)", conexion))
            {
                comando.Parameters.AddWithValue("?", nombre);
                comando.ExecuteNonQuery();
            }
        }
    }
}
