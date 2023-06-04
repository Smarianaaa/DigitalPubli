
namespace Empresa
{
    partial class VistaDetalleProyecto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtSegmentacion = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSegmentacion = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.treeRecursos = new System.Windows.Forms.TreeView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.txtSegmentacion);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblSegmentacion);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 303);
            this.panel1.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(219, 211);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtSegmentacion
            // 
            this.txtSegmentacion.Location = new System.Drawing.Point(86, 56);
            this.txtSegmentacion.Name = "txtSegmentacion";
            this.txtSegmentacion.Size = new System.Drawing.Size(234, 20);
            this.txtSegmentacion.TabIndex = 11;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(86, 96);
            this.txtDescripcion.MaxLength = 500;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(234, 109);
            this.txtDescripcion.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(234, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // lblSegmentacion
            // 
            this.lblSegmentacion.AutoSize = true;
            this.lblSegmentacion.Location = new System.Drawing.Point(5, 59);
            this.lblSegmentacion.Name = "lblSegmentacion";
            this.lblSegmentacion.Size = new System.Drawing.Size(75, 13);
            this.lblSegmentacion.TabIndex = 8;
            this.lblSegmentacion.Text = "Segmentacion";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(17, 99);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(36, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // treeRecursos
            // 
            this.treeRecursos.Location = new System.Drawing.Point(383, 30);
            this.treeRecursos.Name = "treeRecursos";
            this.treeRecursos.Size = new System.Drawing.Size(234, 303);
            this.treeRecursos.TabIndex = 1;
            this.treeRecursos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeRecursos_AfterSelect);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(542, 1);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(383, 340);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(234, 23);
            this.btnDescargar.TabIndex = 4;
            this.btnDescargar.Text = "Descargar Imágenes";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // VistaDetalleProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 374);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.treeRecursos);
            this.Controls.Add(this.panel1);
            this.Name = "VistaDetalleProyecto";
            this.Text = "VistaDetalleProyecto";
            this.Load += new System.EventHandler(this.VistaDetalleProyecto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtSegmentacion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSegmentacion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TreeView treeRecursos;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnDescargar;
    }
}