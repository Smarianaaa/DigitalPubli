
namespace Empresa
{
    partial class AgregarProyecto
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
            this.btnAgregarTexto = new System.Windows.Forms.Button();
            this.btnAgregarImg = new System.Windows.Forms.Button();
            this.txtSegmentacion = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSegmentacion = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.treeElements = new System.Windows.Forms.TreeView();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.opnImg = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregarTexto);
            this.panel1.Controls.Add(this.btnAgregarImg);
            this.panel1.Controls.Add(this.txtSegmentacion);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblSegmentacion);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(30, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 309);
            this.panel1.TabIndex = 0;
            // 
            // btnAgregarTexto
            // 
            this.btnAgregarTexto.Location = new System.Drawing.Point(227, 207);
            this.btnAgregarTexto.Name = "btnAgregarTexto";
            this.btnAgregarTexto.Size = new System.Drawing.Size(104, 23);
            this.btnAgregarTexto.TabIndex = 7;
            this.btnAgregarTexto.Text = "Agregar Texto";
            this.btnAgregarTexto.UseVisualStyleBackColor = true;
            this.btnAgregarTexto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregarImg
            // 
            this.btnAgregarImg.Location = new System.Drawing.Point(91, 207);
            this.btnAgregarImg.Name = "btnAgregarImg";
            this.btnAgregarImg.Size = new System.Drawing.Size(95, 23);
            this.btnAgregarImg.TabIndex = 6;
            this.btnAgregarImg.Text = "Agregar Imagen";
            this.btnAgregarImg.UseVisualStyleBackColor = true;
            this.btnAgregarImg.Click += new System.EventHandler(this.btnAgregarImg_Click);
            // 
            // txtSegmentacion
            // 
            this.txtSegmentacion.Location = new System.Drawing.Point(97, 52);
            this.txtSegmentacion.Name = "txtSegmentacion";
            this.txtSegmentacion.Size = new System.Drawing.Size(234, 20);
            this.txtSegmentacion.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(97, 92);
            this.txtDescripcion.MaxLength = 500;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(234, 109);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 13);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(234, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblSegmentacion
            // 
            this.lblSegmentacion.AutoSize = true;
            this.lblSegmentacion.Location = new System.Drawing.Point(16, 55);
            this.lblSegmentacion.Name = "lblSegmentacion";
            this.lblSegmentacion.Size = new System.Drawing.Size(75, 13);
            this.lblSegmentacion.TabIndex = 2;
            this.lblSegmentacion.Text = "Segmentacion";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(28, 95);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(47, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // treeElements
            // 
            this.treeElements.Location = new System.Drawing.Point(395, 63);
            this.treeElements.Name = "treeElements";
            this.treeElements.Size = new System.Drawing.Size(206, 309);
            this.treeElements.TabIndex = 1;
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Location = new System.Drawing.Point(25, 20);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(222, 25);
            this.lblInformacion.TabIndex = 2;
            this.lblInformacion.Text = "Informacion de Proyecto";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(203, 378);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(350, 378);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // opnImg
            // 
            this.opnImg.FileOk += new System.ComponentModel.CancelEventHandler(this.opnImg_FileOk);
            // 
            // AgregarProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 427);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.treeElements);
            this.Controls.Add(this.panel1);
            this.Name = "AgregarProyecto";
            this.Text = "AgregarProyecto";
            this.Load += new System.EventHandler(this.AgregarProyecto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregarTexto;
        private System.Windows.Forms.Button btnAgregarImg;
        private System.Windows.Forms.TextBox txtSegmentacion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSegmentacion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TreeView treeElements;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.OpenFileDialog opnImg;
    }
}