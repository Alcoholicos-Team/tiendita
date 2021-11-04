namespace ProyectoTienda
{
    partial class fLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ttMensajes = new System.Windows.Forms.ToolTip(this.components);
            this.errorpIngresodeDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.llblContraOlvidada = new System.Windows.Forms.LinkLabel();
            this.btnCuenta = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmboxTipoUsuario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorpIngresodeDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogin
            // 
            this.pbLogin.BackColor = System.Drawing.Color.DarkCyan;
            this.pbLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbLogin.Image")));
            this.pbLogin.Location = new System.Drawing.Point(118, 12);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(110, 123);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogin.TabIndex = 0;
            this.pbLogin.TabStop = false;
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuenta.Location = new System.Drawing.Point(46, 144);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(50, 13);
            this.lblCuenta.TabIndex = 1;
            this.lblCuenta.Text = "Cuenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // txtCuenta
            // 
            this.txtCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuenta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuenta.Location = new System.Drawing.Point(134, 142);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(162, 21);
            this.txtCuenta.TabIndex = 3;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(134, 193);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(162, 21);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnIngresar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.Black;
            this.btnIngresar.Location = new System.Drawing.Point(157, 298);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(255, 298);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errorpIngresodeDatos
            // 
            this.errorpIngresodeDatos.ContainerControl = this;
            // 
            // llblContraOlvidada
            // 
            this.llblContraOlvidada.AutoSize = true;
            this.llblContraOlvidada.Enabled = false;
            this.llblContraOlvidada.Location = new System.Drawing.Point(145, 217);
            this.llblContraOlvidada.Name = "llblContraOlvidada";
            this.llblContraOlvidada.Size = new System.Drawing.Size(132, 13);
            this.llblContraOlvidada.TabIndex = 9;
            this.llblContraOlvidada.TabStop = true;
            this.llblContraOlvidada.Text = "¿Olvidaste tu Contraseña?";
            this.llblContraOlvidada.Visible = false;
            this.llblContraOlvidada.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblContraOlvidada_LinkClicked);
            // 
            // btnCuenta
            // 
            this.btnCuenta.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCuenta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuenta.ForeColor = System.Drawing.Color.Black;
            this.btnCuenta.Location = new System.Drawing.Point(21, 299);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(118, 22);
            this.btnCuenta.TabIndex = 10;
            this.btnCuenta.Text = "Crear Cuenta";
            this.btnCuenta.UseVisualStyleBackColor = false;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(46, 245);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(77, 13);
            this.lblTipo.TabIndex = 11;
            this.lblTipo.Text = "Tipo Cuenta:";
            // 
            // cmboxTipoUsuario
            // 
            this.cmboxTipoUsuario.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxTipoUsuario.FormattingEnabled = true;
            this.cmboxTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Usuario",
            "Cliente"});
            this.cmboxTipoUsuario.Location = new System.Drawing.Point(134, 242);
            this.cmboxTipoUsuario.Name = "cmboxTipoUsuario";
            this.cmboxTipoUsuario.Size = new System.Drawing.Size(162, 21);
            this.cmboxTipoUsuario.TabIndex = 12;
            this.cmboxTipoUsuario.Text = "Seleccione";
            // 
            // fLogin
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(348, 344);
            this.Controls.Add(this.cmboxTipoUsuario);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnCuenta);
            this.Controls.Add(this.llblContraOlvidada);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.pbLogin);
            this.Name = "fLogin";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fIngresodeCuenta_FormClosed);
            this.Load += new System.EventHandler(this.fLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorpIngresodeDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip ttMensajes;
        private System.Windows.Forms.ErrorProvider errorpIngresodeDatos;
        public System.Windows.Forms.PictureBox pbLogin;
        public System.Windows.Forms.Label lblCuenta;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCuenta;
        public System.Windows.Forms.TextBox txtContraseña;
        public System.Windows.Forms.Button btnIngresar;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.LinkLabel llblContraOlvidada;
        public System.Windows.Forms.Button btnCuenta;
        private System.Windows.Forms.ComboBox cmboxTipoUsuario;
        private System.Windows.Forms.Label lblTipo;
    }
}

