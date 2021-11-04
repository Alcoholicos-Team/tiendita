namespace ProyectoTienda
{
    partial class fContraseña
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
            this.btnContraseña = new System.Windows.Forms.Button();
            this.btnCargarLogin = new System.Windows.Forms.Button();
            this.dboxIngresoDatos = new System.Windows.Forms.GroupBox();
            this.cmboxTipodeCuenta = new System.Windows.Forms.ComboBox();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.txtCuentas = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpFechaUsuario = new System.Windows.Forms.DateTimePicker();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblNombreCuenta = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDCuenta = new System.Windows.Forms.TextBox();
            this.dboxIngresoDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContraseña
            // 
            this.btnContraseña.BackColor = System.Drawing.Color.Aquamarine;
            this.btnContraseña.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContraseña.Location = new System.Drawing.Point(377, 64);
            this.btnContraseña.Name = "btnContraseña";
            this.btnContraseña.Size = new System.Drawing.Size(122, 23);
            this.btnContraseña.TabIndex = 14;
            this.btnContraseña.Text = "Nueva contraseña";
            this.btnContraseña.UseVisualStyleBackColor = false;
            this.btnContraseña.Click += new System.EventHandler(this.btnContraseña_Click);
            // 
            // btnCargarLogin
            // 
            this.btnCargarLogin.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCargarLogin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarLogin.Location = new System.Drawing.Point(377, 111);
            this.btnCargarLogin.Name = "btnCargarLogin";
            this.btnCargarLogin.Size = new System.Drawing.Size(122, 27);
            this.btnCargarLogin.TabIndex = 13;
            this.btnCargarLogin.Text = "Ventana Principal";
            this.btnCargarLogin.UseVisualStyleBackColor = false;
            this.btnCargarLogin.Click += new System.EventHandler(this.btnCargarLogin_Click);
            // 
            // dboxIngresoDatos
            // 
            this.dboxIngresoDatos.BackColor = System.Drawing.Color.CadetBlue;
            this.dboxIngresoDatos.Controls.Add(this.txtIDCuenta);
            this.dboxIngresoDatos.Controls.Add(this.label1);
            this.dboxIngresoDatos.Controls.Add(this.cmboxTipodeCuenta);
            this.dboxIngresoDatos.Controls.Add(this.lblTipoCuenta);
            this.dboxIngresoDatos.Controls.Add(this.nudEdad);
            this.dboxIngresoDatos.Controls.Add(this.txtCuentas);
            this.dboxIngresoDatos.Controls.Add(this.txtContraseña);
            this.dboxIngresoDatos.Controls.Add(this.txtNombre);
            this.dboxIngresoDatos.Controls.Add(this.dtpFechaUsuario);
            this.dboxIngresoDatos.Controls.Add(this.lblEdad);
            this.dboxIngresoDatos.Controls.Add(this.lblFecha);
            this.dboxIngresoDatos.Controls.Add(this.lblContraseña);
            this.dboxIngresoDatos.Controls.Add(this.lblNombreCuenta);
            this.dboxIngresoDatos.Controls.Add(this.lblNombre);
            this.dboxIngresoDatos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dboxIngresoDatos.ForeColor = System.Drawing.Color.Black;
            this.dboxIngresoDatos.Location = new System.Drawing.Point(12, 12);
            this.dboxIngresoDatos.Name = "dboxIngresoDatos";
            this.dboxIngresoDatos.Size = new System.Drawing.Size(348, 283);
            this.dboxIngresoDatos.TabIndex = 10;
            this.dboxIngresoDatos.TabStop = false;
            this.dboxIngresoDatos.Text = "Ingreso de Datos";
            // 
            // cmboxTipodeCuenta
            // 
            this.cmboxTipodeCuenta.Enabled = false;
            this.cmboxTipodeCuenta.FormattingEnabled = true;
            this.cmboxTipodeCuenta.Items.AddRange(new object[] {
            "Administrador",
            "Uusario",
            "Cliente"});
            this.cmboxTipodeCuenta.Location = new System.Drawing.Point(133, 247);
            this.cmboxTipodeCuenta.Name = "cmboxTipodeCuenta";
            this.cmboxTipodeCuenta.Size = new System.Drawing.Size(121, 21);
            this.cmboxTipodeCuenta.TabIndex = 11;
            this.cmboxTipodeCuenta.Text = "Seleccione";
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Location = new System.Drawing.Point(7, 247);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(94, 13);
            this.lblTipoCuenta.TabIndex = 10;
            this.lblTipoCuenta.Text = "Tipo de Cuenta:";
            // 
            // nudEdad
            // 
            this.nudEdad.Enabled = false;
            this.nudEdad.Location = new System.Drawing.Point(133, 206);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(50, 21);
            this.nudEdad.TabIndex = 9;
            this.nudEdad.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // txtCuentas
            // 
            this.txtCuentas.Enabled = false;
            this.txtCuentas.Location = new System.Drawing.Point(133, 93);
            this.txtCuentas.Name = "txtCuentas";
            this.txtCuentas.Size = new System.Drawing.Size(204, 21);
            this.txtCuentas.TabIndex = 8;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(133, 126);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(204, 21);
            this.txtContraseña.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(133, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(204, 21);
            this.txtNombre.TabIndex = 5;
            // 
            // dtpFechaUsuario
            // 
            this.dtpFechaUsuario.Enabled = false;
            this.dtpFechaUsuario.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaUsuario.Location = new System.Drawing.Point(133, 166);
            this.dtpFechaUsuario.Name = "dtpFechaUsuario";
            this.dtpFechaUsuario.Size = new System.Drawing.Size(121, 21);
            this.dtpFechaUsuario.TabIndex = 1;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(7, 206);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(37, 13);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(7, 166);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(126, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha de Nacimiento:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(7, 129);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(75, 13);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblNombreCuenta
            // 
            this.lblNombreCuenta.AutoSize = true;
            this.lblNombreCuenta.Location = new System.Drawing.Point(7, 96);
            this.lblNombreCuenta.Name = "lblNombreCuenta";
            this.lblNombreCuenta.Size = new System.Drawing.Size(97, 13);
            this.lblNombreCuenta.TabIndex = 1;
            this.lblNombreCuenta.Text = "Nombre Cuenta:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(377, 172);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 26);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir de la Ventana";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID Cuenta:";
            // 
            // txtIDCuenta
            // 
            this.txtIDCuenta.Enabled = false;
            this.txtIDCuenta.Location = new System.Drawing.Point(133, 25);
            this.txtIDCuenta.Name = "txtIDCuenta";
            this.txtIDCuenta.Size = new System.Drawing.Size(204, 21);
            this.txtIDCuenta.TabIndex = 13;
            // 
            // fContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(509, 311);
            this.Controls.Add(this.btnContraseña);
            this.Controls.Add(this.btnCargarLogin);
            this.Controls.Add(this.dboxIngresoDatos);
            this.Controls.Add(this.btnSalir);
            this.Name = "fContraseña";
            this.Text = "Cambio de Contraseña";
            this.Load += new System.EventHandler(this.fContraseña_Load);
            this.dboxIngresoDatos.ResumeLayout(false);
            this.dboxIngresoDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContraseña;
        private System.Windows.Forms.Button btnCargarLogin;
        private System.Windows.Forms.GroupBox dboxIngresoDatos;
        private System.Windows.Forms.ComboBox cmboxTipodeCuenta;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.TextBox txtCuentas;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaUsuario;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblNombreCuenta;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtIDCuenta;
        private System.Windows.Forms.Label label1;
    }
}