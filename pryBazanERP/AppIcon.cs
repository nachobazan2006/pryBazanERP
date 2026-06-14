using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace pryBazanERP
{
    internal static class AppIcon
    {
        public static void Aplicar(Form formulario)
        {
            string rutaIcono = Path.Combine(Application.StartupPath, "Assets", "App.ico");

            if (!File.Exists(rutaIcono))
            {
                rutaIcono = Path.Combine(Application.StartupPath, "App.ico");

                if (!File.Exists(rutaIcono))
                {
                    return;
                }
            }

            formulario.Icon = new Icon(rutaIcono);
        }
    }
}
