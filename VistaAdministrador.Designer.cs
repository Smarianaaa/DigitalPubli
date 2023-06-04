
namespace Empresa
{
    partial class VistaAdministrador
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
            this.btnProyectos = new System.Windows.Forms.Button();
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblClientes = new System.Windows.Forms.Label();
            this.btnSubir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSubir);
            this.panel1.Controls.Add(this.btnProyectos);
            this.panel1.Controls.Add(this.dtgCliente);
            this.panel1.Location = new System.Drawing.Point(28, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 303);
            this.panel1.TabIndex = 0;
            // 
            // btnProyectos
            // 
            this.btnProyectos.Location = new System.Drawing.Point(9, 249);
            this.btnProyectos.Name = "btnProyectos";
            this.btnProyectos.Size = new System.Drawing.Size(185, 23);
            this.btnProyectos.TabIndex = 1;
            this.btnProyectos.Text = "Ver Proyectos";
            this.btnProyectos.UseVisualStyleBackColor = true;
            this.btnProyectos.Click += new System.EventHandler(this.btnProyectos_Click);
            // 
            // dtgCliente
            // 
            this.dtgCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Location = new System.Drawing.Point(9, 15);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.Size = new System.Drawing.Size(845, 228);
            this.dtgCliente.TabIndex = 0;
            this.dtgCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCliente_CellContentClick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(801, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(118, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar Sesión";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblClientes
            // 
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(23, 51);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(106, 24);
            this.lblClientes.TabIndex = 2;
            this.lblClientes.Text = "Clientes";
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(217, 249);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(185, 23);
            this.btnSubir.TabIndex = 2;
            this.btnSubir.Text = "Subir Resultado";
            this.btnSubir.UseVisualStyleBackColor = true;
            // 
            // VistaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 419);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel1);
            this.Name = "VistaAdministrador";
            this.Text = "VistaAdministrador";
            this.Load += new System.EventHandler(this.VistaAdministrador_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProyectos;
        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Button btnSubir;
    }
}