using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    public partial class VistaDetalleProyecto : Form
    {
        private int proyectoId;
        private Proyecto proyecto;
        private List<String> listaUrls;
        private List<String> listaTextos;
        public VistaDetalleProyecto(int proyectoId)
        {
            this.proyectoId = proyectoId;
            InitializeComponent();
            Console.WriteLine(proyectoId);
            listaUrls = new List<String>();
            listaTextos = new List<string>();

            try { 
                this.mostrarDetalleProyecto();
                this.txtNombre.Text = proyecto.nombre;
                this.txtDescripcion.Text = proyecto.descripcion;
                this.txtSegmentacion.Text = proyecto.segmentacion;
                this.treeRecursos.Nodes.Add("Imagenes");
                this.treeRecursos.Nodes.Add("Texto");
                this.mostrarTextoImagenes();
            }catch(Exception e)
            {
                MessageBox.Show("Error al mostrar el detalle del proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new VistaCliente(Program.usuarioLogeado).Show();
        }

        private void VistaDetalleProyecto_Load(object sender, EventArgs e)
        {

        }

        private void mostrarDetalleProyecto()
        {
            
            SqlConnection conexion = new SqlConnection(Program.baseDatos);
            conexion.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM DIGITAL_PUBLI.dbo.Proyecto WHERE ProyectoID = @proyecto;", conexion);
            command.Parameters.AddWithValue("@proyecto", this.proyectoId);

            SqlDataReader reader = command.ExecuteReader();

            Proyecto proyectoObtenido = new Proyecto();

            while (reader.Read())
            {
                proyectoObtenido.proyectoId = (int)reader.GetValue(0);
                proyectoObtenido.nombre = reader.GetValue(1).ToString();
                proyectoObtenido.descripcion = reader.GetValue(2).ToString();
                proyectoObtenido.estado = reader.GetValue(3).ToString();
                proyectoObtenido.segmentacion = reader.GetValue(4).ToString();
                proyectoObtenido.usuarioId = (int)reader.GetValue(5);
            }

            reader.Close();
            conexion.Close();

            this.proyecto = proyectoObtenido;
            
        }

        private void mostrarTextoImagenes()
        {
            
            
            SqlConnection conexion = new SqlConnection(Program.baseDatos);
            conexion.Open();

            SqlCommand command = new SqlCommand("SELECT dp.texto, dp.ProyectoID, dp.UsuarioID, dp.ImgID, dp.ResultadoPublicidad, di.nombreImagen, di.imgUrl, di.img FROM DIGITAL_PUBLI.dbo.Detalle_Proyecto dp INNER JOIN DIGITAL_PUBLI.dbo.Detalle_Imagen di ON (dp.ImgID = di.ImgID) WHERE ProyectoID = @proyecto and UsuarioID = @usuario;", conexion);
            command.Parameters.AddWithValue("@proyecto", this.proyectoId);
            command.Parameters.AddWithValue("@usuario", Program.usuarioLogeado.usuarioId);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if(reader.GetValue(0).ToString().Equals(""))
                {
                    this.treeRecursos.Nodes[0].Nodes.Add(reader.GetValue(5).ToString());
                    
                    this.treeRecursos.ExpandAll();
                }else if(reader.GetValue(3).ToString().Equals(""))
                {
                    this.treeRecursos.Nodes[1].Nodes.Add(reader.GetValue(0).ToString());
                    this.listaTextos.Add(reader.GetValue(0).ToString());
                    this.treeRecursos.ExpandAll();
                }

            }
            reader.Close();
            conexion.Close();
            this.treeRecursos.ExpandAll();
        }

        private void treeRecursos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.treeRecursos.SelectedNode.Parent != null)
            {
                
                //Console.WriteLine(listaUrls[this.treeRecursos.SelectedNode.Index]);
                //MessageBox.Show(listaUrls[this.treeRecursos.SelectedNode.Index], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public static byte[] StringToByteArray(string hex)
        {
            char[] charArray = hex.ToCharArray();
            byte[] byteArray = new byte[charArray.Length];

            for (int i = 0; i < charArray.Length; i++)
            {
                byteArray[i] = (byte)charArray[i];
            }

            return byteArray;
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(Program.baseDatos);
            conexion.Open();

            SqlCommand command = new SqlCommand("SELECT di.nombreImagen, di.imgUrl, di.img  FROM DIGITAL_PUBLI.dbo.Detalle_Proyecto dp INNER JOIN DIGITAL_PUBLI.dbo.Detalle_Imagen di ON (dp.ImgID = di.ImgID) WHERE ProyectoID = @proyecto and UsuarioID = @usuario AND dp.ImgID is not null;", conexion);
            command.Parameters.AddWithValue("@proyecto", this.proyectoId);
            command.Parameters.AddWithValue("@usuario", Program.usuarioLogeado.usuarioId);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                

            }
            reader.Close();
            conexion.Close();
        }
    }
}
