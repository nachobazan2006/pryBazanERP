using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            { return false; }
        }
    }
}
