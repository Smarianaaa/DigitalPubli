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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario nuevoUsuario = new Usuario();

                nuevoUsuario.nombre = txtNombre.Text;
                nuevoUsuario.nombreUsuario = txtNombreUsuario.Text;
                nuevoUsuario.direccion = txtDireccion.Text;
                nuevoUsuario.tipo = cmbTipoUsuario.Text;
                nuevoUsuario.correo = txtCorreo.Text;
                nuevoUsuario.telefono = txtTelefono.Text;
                nuevoUsuario.celular = txtCelular.Text;
                nuevoUsuario.password = txtPassword.Text;
                UsuarioDB usuarioBase = new UsuarioDB();
                usuarioBase.agregarUsuario(nuevoUsuario);
                MessageBox.Show("Registro realizado exitosamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new Login().Show();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Ocurrió un error al registrar usuario.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(exception);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ingreso = new Login();
            ingreso.Show();
        }
    }
}
