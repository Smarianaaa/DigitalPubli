using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    public partial class Login : Form
    {
        public Login()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            string nombreUsuario = txtUsuario.Text;
            string password = txtPassword.Text;

            /*
            this.Hide();
            RegistroUsuario registrar = new RegistroUsuario();
            registrar.Show();*/

            UsuarioDB usuarioBusqueda = new UsuarioDB();
            Usuario usuarioObtenido = usuarioBusqueda.buscarUsuario(nombreUsuario);

            if (!usuarioObtenido.nombreUsuario.Equals(""))
            {
                
                if (password.Equals(usuarioObtenido.password))
                {
                    this.Hide();
                    if (usuarioObtenido.tipo.Equals("Admin"))
                    {
                        Program.usuarioLogeado = usuarioObtenido;
                        VistaAdministrador vistaAdministrador = new VistaAdministrador(usuarioObtenido);
                        new VistaAdministrador(usuarioObtenido).Show();
                        
                    }
                    else
                    {
                        
                        Program.usuarioLogeado = usuarioObtenido;
                        VistaCliente vistaCliente = new VistaCliente(usuarioObtenido);
                        Console.WriteLine(Program.usuarioLogeado.nombreUsuario);
                        //vistaCliente.SetNombreUsuario(usuarioObtenido.nombreUsuario);
                        vistaCliente.Show();
                        
                    }
                    
                    
                }
                else
                {
                    MessageBox.Show("La contraseña está incorrecta");
                }
            }
            else
            {
                MessageBox.Show("El usuario ingresado no existe.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroUsuario registrar = new RegistroUsuario();
            registrar.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
