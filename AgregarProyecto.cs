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
    public partial class AgregarProyecto : Form
    {
        private List<String> listaUrls;
        private List<String> listaTexto;

        private List<Imagen> listaImagenes;

        private String nombreProyecto;
        private String segmentacionProyecto;
        private String descripcionProyecto;
        private int proyectoId;

        public static string textoProyecto;

        public AgregarProyecto()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            listaImagenes = new List<Imagen>();
            InitializeComponent();
            this.treeElements.Nodes.Add("Imagenes");
            this.treeElements.Nodes.Add("Texto");
            this.listaUrls = new List<String>();
            this.listaTexto = new List<String>();
            this.opnImg.DefaultExt = ".jpg";
            opnImg.Filter = "Files|*.jpg;*.jpeg;*.png;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String textoAgregar;
            AgregarTexto ventanaTexto = new AgregarTexto();
            ventanaTexto.ShowDialog();
            if(textoProyecto.Length > 15)
            {
                textoAgregar = textoProyecto.Substring(0, 15) + "...";
            }
            else
            {
                textoAgregar = textoProyecto;
            }
            this.treeElements.Nodes[1].Nodes.Add(textoAgregar);
            this.listaTexto.Add(textoAgregar);
            this.treeElements.ExpandAll();
            
        }

        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            opnImg.ShowDialog();
        }

        private void opnImg_FileOk(object sender, CancelEventArgs e)
        {
            String imgUrl = "";
            String imgNombre = "";

            imgUrl = opnImg.FileName;
            imgNombre = opnImg.SafeFileName;
            Imagen nuevaImagen = new Imagen();
            nuevaImagen.urlImage = imgUrl;
            nuevaImagen.nombreImagen = imgNombre;
            this.listaImagenes.Add(nuevaImagen);
            this.treeElements.Nodes[0].Nodes.Add(imgNombre);
            this.treeElements.ExpandAll();
            this.listaUrls.Add(imgUrl);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int imgId = 0;
            nombreProyecto = this.txtNombre.Text;
            segmentacionProyecto = this.txtSegmentacion.Text;
            descripcionProyecto = this.txtSegmentacion.Text;
            try { 
                using(var con = new SqlConnection(Program.baseDatos))
                {
                
                    var cmd = "insert into DIGITAL_PUBLI.dbo.Proyecto (Nombre, Descripcion, Estado, Segmentacion, UsuarioID) VALUES(@nombre, @descripcion, @estado, @segmentacion, @usuario);SELECT CAST(scope_identity() AS int);";
                    using (var insertCommand = new SqlCommand(cmd, con))
                    {
                        insertCommand.Parameters.AddWithValue("@nombre", nombreProyecto);
                        insertCommand.Parameters.AddWithValue("@descripcion", descripcionProyecto);
                        insertCommand.Parameters.AddWithValue("@estado", "Pendiente");
                        insertCommand.Parameters.AddWithValue("@segmentacion", segmentacionProyecto);
                        insertCommand.Parameters.AddWithValue("@usuario", Program.usuarioLogeado.usuarioId);
                        con.Open();
                        this.proyectoId = (int)insertCommand.ExecuteScalar();
                    }
                }


                using (var con = new SqlConnection(Program.baseDatos))
                {

                
                    for (int i = 0; i < this.listaImagenes.Count; i++)
                    {
                        var cmd = "INSERT INTO DIGITAL_PUBLI.dbo.Detalle_Imagen (nombreImagen, img) SELECT '"+listaImagenes[i].nombreImagen+"', * FROM OPENROWSET(BULK N'" + listaImagenes[i].urlImage + "', SINGLE_BLOB) image; SELECT CAST(scope_identity() AS int); ";
                        using (var insertCommand = new SqlCommand(cmd, con))
                        {
                            con.Open();
                            imgId = (int)insertCommand.ExecuteScalar();
                            con.Close();
                        }
                        cmd = "UPDATE DIGITAL_PUBLI.dbo.Detalle_Imagen SET imgUrl = '"+listaImagenes[i].urlImage+"' WHERE ImgID = "+imgId.ToString()+"; ";
                        using (var insertCommand = new SqlCommand(cmd, con))
                        {
                            con.Open();
                            insertCommand.ExecuteNonQuery();
                            con.Close();
                        }

                        cmd = "INSERT INTO DIGITAL_PUBLI.dbo.Detalle_Proyecto(ProyectoID, UsuarioID, ImgID) VALUES(@proyecto, @usuario, @img);";
                        using (var insertCommand = new SqlCommand(cmd, con))
                        {
                            insertCommand.Parameters.AddWithValue("@proyecto", this.proyectoId);
                            insertCommand.Parameters.AddWithValue("@usuario", Program.usuarioLogeado.usuarioId);
                            insertCommand.Parameters.AddWithValue("@img", imgId);
                            con.Open();
                            insertCommand.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }


                using (var con = new SqlConnection(Program.baseDatos))
                {
                    for (int i = 0; i < this.listaTexto.Count; i++)
                    {
                        var cmd = "INSERT INTO DIGITAL_PUBLI.dbo.Detalle_Proyecto(ProyectoID, UsuarioID, texto) VALUES(@proyecto, @usuario, @texto);";
                        using (var insertCommand = new SqlCommand(cmd, con))
                        {
                            insertCommand.Parameters.AddWithValue("@proyecto", this.proyectoId);
                            insertCommand.Parameters.AddWithValue("@usuario", Program.usuarioLogeado.usuarioId);
                            insertCommand.Parameters.AddWithValue("@texto", this.listaTexto[i]);
                            con.Open();
                            insertCommand.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
                MessageBox.Show("Proyecto Guardado Exitosamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                new VistaCliente(Program.usuarioLogeado).Show();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error al guardar el proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            new VistaCliente(Program.usuarioLogeado).Show();
        }

        private void AgregarProyecto_Load(object sender, EventArgs e)
        {

        }
    }
}
