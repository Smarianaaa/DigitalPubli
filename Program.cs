using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    static class Program
    {
        public static Usuario usuarioLogeado;
        public static string baseDatos = "Server=MSI\\SQLEXPRESS;Database=DIGITAL_PUBLI; Integrated Security=True";
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            ConexionBaseDeDatos conexion = new ConexionBaseDeDatos();
            conexion.abrir();
        }
    }
}
