using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    public partial class VistaAdministrador : Form
    {
        public VistaAdministrador(Usuario usuarioSeleccionado)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            dtgCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCliente.MultiSelect = false;
            try
            {
                

                SqlConnection conexion = new SqlConnection(Program.baseDatos);
                conexion.Open();
                SqlCommand command = new SqlCommand("SELECT UsuarioID as ID, Nombre as Nombre, nombreUsuario as Usuario, tipo as Tipo, Correo as Correo, Telefono as Telefono, celular as Celular, Direccion as Direccion FROM usuario WHERE tipo='Cliente';", conexion);

                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable table = new DataTable();
               
                
                sda.Fill(table);
                dtgCliente.DataSource = table;
                conexion.Close();

            } catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error");
                Console.WriteLine(e);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void VistaAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void obtenerClientes() { 
            
        
        }

        private void dtgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnProyectos_Click(object sender, EventArgs e)
        {

        }
    }
}
