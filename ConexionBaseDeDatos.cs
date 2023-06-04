using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class ConexionBaseDeDatos
    {

        string baseDatos = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=DIGITAL_PUBLI; Integrated Security=True";
        public SqlConnection conexion = new SqlConnection(); 

        public ConexionBaseDeDatos()
        {
            conexion.ConnectionString = baseDatos;
        }

        public void abrir()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion Abierta");
            }
            catch(Exception ex)
            {
            
                Console.WriteLine("Error al abrir la Base de Datos");
            
            }
            
        }

        public void cerrar()
        {
            conexion.Close();
        }
    }
}
