
namespace Empresa
{
    partial class RegistroUsuario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRegistroUsuario = new System.Windows.Forms.Label();
            this.pnlRegistroUsuario = new System.Windows.Forms.Panel();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlRegistroUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistroUsuario
            // 
            this.lblRegistroUsuario.AutoSize = true;
            this.lblRegistroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroUsuario.Location = new System.Drawing.Point(145, 30);
            this.lblRegistroUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistroUsuario.Name = "lblRegistroUsuario";
            this.lblRegistroUsuario.Size = new System.Drawing.Size(201, 29);
            this.lblRegistroUsuario.TabIndex = 0;
            this.lblRegistroUsuario.Text = "Registro Usuario";
            // 
            // pnlRegistroUsuario
            // 
            this.pnlRegistroUsuario.Controls.Add(this.txtPassword);
            this.pnlRegistroUsuario.Controls.Add(this.label1);
            this.pnlRegistroUsuario.Controls.Add(this.cmbTipoUsuario);
            this.pnlRegistroUsuario.Controls.Add(this.btnCancelar);
            this.pnlRegistroUsuario.Controls.Add(this.btnRegistrar);
            this.pnlRegistroUsuario.Controls.Add(this.txtDireccion);
            this.pnlRegistroUsuario.Controls.Add(this.txtCelular);
            this.pnlRegistroUsuario.Controls.Add(this.txtTelefono);
            this.pnlRegistroUsuario.Controls.Add(this.txtCorreo);
            this.pnlRegistroUsuario.Controls.Add(this.txtNombreUsuario);
            this.pnlRegistroUsuario.Controls.Add(this.txtNombre);
            this.pnlRegistroUsuario.Controls.Add(this.label7);
            this.pnlRegistroUsuario.Controls.Add(this.label6);
            this.pnlRegistroUsuario.Controls.Add(this.label5);
            this.pnlRegistroUsuario.Controls.Add(this.label4);
            this.pnlRegistroUsuario.Controls.Add(this.lblTipo);
            this.pnlRegistroUsuario.Controls.Add(this.lblUsuario);
            this.pnlRegistroUsuario.Controls.Add(this.lblNombre);
            this.pnlRegistroUsuario.Location = new System.Drawing.Point(35, 64);
            this.pnlRegistroUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRegistroUsuario.Name = "pnlRegistroUsuario";
            this.pnlRegistroUsuario.Size = new System.Drawing.Size(425, 476);
            this.pnlRegistroUsuario.TabIndex = 1;
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Cliente"});
            this.cmbTipoUsuario.Location = new System.Drawing.Point(117, 149);
            this.cmbTipoUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(281, 24);
            this.cmbTipoUsuario.TabIndex = 16;
            this.cmbTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(256, 414);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(85, 414);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 28);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(117, 322);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(281, 22);
            this.txtDireccion.TabIndex = 13;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(117, 279);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(281, 22);
            this.txtCelular.TabIndex = 12;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(117, 235);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(281, 22);
            this.txtTelefono.TabIndex = 11;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(117, 187);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(281, 22);
            this.txtCorreo.TabIndex = 10;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(117, 106);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(281, 22);
            this.txtNombreUsuario.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 64);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(281, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 331);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Celular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(49, 149);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 17);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(49, 106);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 17);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.UseWaitCursor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(49, 64);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(117, 369);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(281, 22);
            this.txtPassword.TabIndex = 18;
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 573);
            this.Controls.Add(this.pnlRegistroUsuario);
            this.Controls.Add(this.lblRegistroUsuario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistroUsuario";
            this.Text = "Registro Usuario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlRegistroUsuario.ResumeLayout(false);
            this.pnlRegistroUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistroUsuario;
        private System.Windows.Forms.Panel pnlRegistroUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
    }
}

