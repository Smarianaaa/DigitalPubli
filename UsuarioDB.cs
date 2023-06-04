using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    class UsuarioDB
    {

        public UsuarioDB()
        {

        }

        public int agregarUsuario(Usuario nuevoUsuario)
        {
            
            int retorno = 0;
            String tipo = "";
            if (nuevoUsuario.tipo.Equals("Administrador"))
            {
                tipo = "Admin";
            }
            else
            {
                tipo = "Cliente";
            }
            string query = string.Format("INSERT INTO Usuario (Nombre, nombreUsuario, Tipo, Correo, Telefono, Celular, Direccion, Pass) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", nuevoUsuario.nombre, nuevoUsuario.nombreUsuario, tipo, nuevoUsuario.correo, nuevoUsuario.telefono, nuevoUsuario.celular, nuevoUsuario.direccion, nuevoUsuario.password);
            SqlConnection conexion = new SqlConnection(Program.baseDatos);
            conexion.Open();

            SqlCommand comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();
            
            

            return retorno;
        }

        public Usuario buscarUsuario(String nombreUsuario)
        {
            string baseDatos = "Server=MSI\\SQLEXPRESS;Database=DIGITAL_PUBLI; Integrated Security=True";
            SqlConnection conexion = new SqlConnection(baseDatos);
            conexion.Open();
            int retorno = 0;
            //String usuarioObtenido = "";
            String passwordObetnida = "";
            String tipoUsuario = "";

            SqlCommand command = new SqlCommand("SELECT * FROM usuario WHERE nombreUsuario = @usuario;", conexion);

            command.Parameters.AddWithValue("@usuario", nombreUsuario);

            SqlDataReader reader = command.ExecuteReader();

            Usuario usuarioObtenido = new Usuario();

            while (reader.Read())
            {
                usuarioObtenido.usuarioId = (int)reader.GetValue(0);
                usuarioObtenido.nombre = reader.GetValue(1).ToString();
                usuarioObtenido.nombreUsuario = reader.GetValue(2).ToString();
                usuarioObtenido.tipo = reader.GetValue(3).ToString();
                usuarioObtenido.correo = reader.GetValue(4).ToString();
                usuarioObtenido.telefono = reader.GetValue(5).ToString();
                usuarioObtenido.celular = reader.GetValue(6).ToString();
                usuarioObtenido.direccion = reader.GetValue(7).ToString();
                usuarioObtenido.password = reader.GetValue(8).ToString();
            }
           

            // result gives the -1 output.. but on insert its 1
            /*
            using (SqlDataReader reader = command.ExecuteReader())
            {
                // iterate your results here
                Console.WriteLine(String.Format("{0}", reader["nombreUsuario"]));
            }*/
            reader.Close();
            conexion.Close();

            return usuarioObtenido;
        }

        
    }
}
