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
    public partial class VistaCliente : Form
    {
        //private Usuario usuarioSeleccionado;
        private Usuario usuarioSeleccionado;
        private String nombreUsuario;
        public VistaCliente(Usuario usuarioSeleccionado)
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            lblBienvenido.Text = "Bienvenido " + usuarioSeleccionado.nombreUsuario;
            txtNombre.Text = usuarioSeleccionado.nombre;
            txtUsuario.Text = usuarioSeleccionado.nombreUsuario;
            txtTipo.Text = usuarioSeleccionado.tipo;
            txtCorreo.Text = usuarioSeleccionado.correo;
            txtTelefono.Text = usuarioSeleccionado.telefono;
            txtCelular.Text = usuarioSeleccionado.celular;
            txtDireccion.Text = usuarioSeleccionado.direccion;
            this.usuarioSeleccionado = usuarioSeleccionado;
            dtgProyectosUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProyectosUsuario.MultiSelect = false;
            dtgProyectosUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mostrarProyectosUsuario();
            dtgProyectosUsuario.Columns["ID"].Visible = false;
            
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void VistaCliente_Load(object sender, EventArgs e)
        {

        }

        public void SetNombreUsuario(String nombreUsuario)
        {
            this.nombreUsuario = nombreUsuario;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AgregarProyecto().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mostrarProyectosUsuario()
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.baseDatos);
                var cmd = "SELECT p.ProyectoID as 'ID', ROW_NUMBER()OVER(ORDER BY p.Nombre) as 'No.', p.Nombre as 'Nombre', p.Estado as 'Estado'  FROM DIGITAL_PUBLI.dbo.Proyecto p WHERE p.UsuarioID = "+Program.usuarioLogeado.usuarioId.ToString()+";";

                con.Open();
                SqlCommand command = new SqlCommand(cmd, con);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                sda.Fill(table);
                dtgProyectosUsuario.DataSource = table;
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error");
                Console.WriteLine(e);
            }
        }

        

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            int idProyecto = 0;
            if (dtgProyectosUsuario.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dtgProyectosUsuario.SelectedRows[0];
                if(!(row.Cells["ID"].Value is null))
                {
                    idProyecto = (int)row.Cells["ID"].Value;
                    VistaDetalleProyecto detalle = new VistaDetalleProyecto(idProyecto);
                    detalle.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                

            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
