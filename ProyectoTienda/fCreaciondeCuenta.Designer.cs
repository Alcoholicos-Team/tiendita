namespace ProyectoTienda
{
    partial class fCreaciondeCuenta
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
            this.components = new System.ComponentModel.Container();
            this.dboxIngresoDatos = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.cmboxTipodeCuenta = new System.Windows.Forms.ComboBox();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.txtNOmbreCuenta = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpFechaUsuario = new System.Windows.Forms.DateTimePicker();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblNombreCuenta = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.errorDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensajes = new System.Windows.Forms.ToolTip(this.components);
            this.btnCargarLogin = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gboxCuentas = new System.Windows.Forms.GroupBox();
            this.dgvDatosCuentas = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dboxIngresoDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDatos)).BeginInit();
            this.gboxCuentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dboxIngresoDatos
            // 
            this.dboxIngresoDatos.BackColor = System.Drawing.Color.CadetBlue;
            this.dboxIngresoDatos.Controls.Add(this.txtID);
            this.dboxIngresoDatos.Controls.Add(this.lblID);
            this.dboxIngresoDatos.Controls.Add(this.cmboxTipodeCuenta);
            this.dboxIngresoDatos.Controls.Add(this.lblTipoCuenta);
            this.dboxIngresoDatos.Controls.Add(this.nudEdad);
            this.dboxIngresoDatos.Controls.Add(this.txtNOmbreCuenta);
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
            this.dboxIngresoDatos.Size = new System.Drawing.Size(360, 281);
            this.dboxIngresoDatos.TabIndex = 0;
            this.dboxIngresoDatos.TabStop = false;
            this.dboxIngresoDatos.Text = "Ingreso de Datos";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(132, 26);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(204, 21);
            this.txtID.TabIndex = 13;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(9, 26);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(65, 13);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "ID Cliente:";
            // 
            // cmboxTipodeCuenta
            // 
            this.cmboxTipodeCuenta.FormattingEnabled = true;
            this.cmboxTipodeCuenta.Items.AddRange(new object[] {
            "Administrador",
            "Usuario",
            "Cliente"});
            this.cmboxTipodeCuenta.Location = new System.Drawing.Point(132, 246);
            this.cmboxTipodeCuenta.Name = "cmboxTipodeCuenta";
            this.cmboxTipodeCuenta.Size = new System.Drawing.Size(121, 21);
            this.cmboxTipodeCuenta.TabIndex = 11;
            this.cmboxTipodeCuenta.Text = "Seleccione";
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Location = new System.Drawing.Point(6, 246);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(94, 13);
            this.lblTipoCuenta.TabIndex = 10;
            this.lblTipoCuenta.Text = "Tipo de Cuenta:";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(132, 205);
            this.nudEdad.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(50, 21);
            this.nudEdad.TabIndex = 9;
            this.nudEdad.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // txtNOmbreCuenta
            // 
            this.txtNOmbreCuenta.Location = new System.Drawing.Point(132, 92);
            this.txtNOmbreCuenta.Name = "txtNOmbreCuenta";
            this.txtNOmbreCuenta.Size = new System.Drawing.Size(204, 21);
            this.txtNOmbreCuenta.TabIndex = 8;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(132, 125);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(204, 21);
            this.txtContraseña.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(132, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(204, 21);
            this.txtNombre.TabIndex = 5;
            // 
            // dtpFechaUsuario
            // 
            this.dtpFechaUsuario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaUsuario.Location = new System.Drawing.Point(132, 165);
            this.dtpFechaUsuario.Name = "dtpFechaUsuario";
            this.dtpFechaUsuario.Size = new System.Drawing.Size(134, 21);
            this.dtpFechaUsuario.TabIndex = 1;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(9, 207);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(37, 13);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(6, 165);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(126, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha de Nacimiento:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(6, 128);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(75, 13);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblNombreCuenta
            // 
            this.lblNombreCuenta.AutoSize = true;
            this.lblNombreCuenta.Location = new System.Drawing.Point(6, 95);
            this.lblNombreCuenta.Name = "lblNombreCuenta";
            this.lblNombreCuenta.Size = new System.Drawing.Size(97, 13);
            this.lblNombreCuenta.TabIndex = 1;
            this.lblNombreCuenta.Text = "Nombre Cuenta:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnLimpiar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(378, 212);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(122, 26);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Lmpiar Datos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCrear.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(378, 28);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(122, 23);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.Text = "Crear Cuenta";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // errorDatos
            // 
            this.errorDatos.ContainerControl = this;
            // 
            // btnCargarLogin
            // 
            this.btnCargarLogin.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCargarLogin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarLogin.Location = new System.Drawing.Point(378, 254);
            this.btnCargarLogin.Name = "btnCargarLogin";
            this.btnCargarLogin.Size = new System.Drawing.Size(122, 27);
            this.btnCargarLogin.TabIndex = 8;
            this.btnCargarLogin.Text = "Ventana Principal";
            this.btnCargarLogin.UseVisualStyleBackColor = false;
            this.btnCargarLogin.Click += new System.EventHandler(this.btnCargarLogin_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnActualizar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(378, 73);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(122, 23);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar Cuenta";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // gboxCuentas
            // 
            this.gboxCuentas.BackColor = System.Drawing.Color.CadetBlue;
            this.gboxCuentas.Controls.Add(this.dgvDatosCuentas);
            this.gboxCuentas.Location = new System.Drawing.Point(12, 312);
            this.gboxCuentas.Name = "gboxCuentas";
            this.gboxCuentas.Size = new System.Drawing.Size(476, 188);
            this.gboxCuentas.TabIndex = 11;
            this.gboxCuentas.TabStop = false;
            this.gboxCuentas.Text = "Datos Cuentas";
            // 
            // dgvDatosCuentas
            // 
            this.dgvDatosCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosCuentas.Location = new System.Drawing.Point(12, 20);
            this.dgvDatosCuentas.Name = "dgvDatosCuentas";
            this.dgvDatosCuentas.Size = new System.Drawing.Size(458, 162);
            this.dgvDatosCuentas.TabIndex = 0;
            this.dgvDatosCuentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosCuentas_CellClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnEliminar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(378, 167);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar Cuenta";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnBuscar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(378, 120);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(122, 26);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar Cuenta";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // fCreaciondeCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(512, 512);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gboxCuentas);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCargarLogin);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dboxIngresoDatos);
            this.Controls.Add(this.btnLimpiar);
            this.Name = "fCreaciondeCuenta";
            this.Text = "Procesos de Cuentas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fCreaciondeCuenta_FormClosed);
            this.Load += new System.EventHandler(this.fCreaciondeCuenta_Load);
            this.dboxIngresoDatos.ResumeLayout(false);
            this.dboxIngresoDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDatos)).EndInit();
            this.gboxCuentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCuentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dboxIngresoDatos;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.TextBox txtNOmbreCuenta;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaUsuario;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblNombreCuenta;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ErrorProvider errorDatos;
        private System.Windows.Forms.ToolTip ttMensajes;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.Button btnCargarLogin;
        private System.Windows.Forms.ComboBox cmboxTipodeCuenta;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gboxCuentas;
        private System.Windows.Forms.DataGridView dgvDatosCuentas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
    }
}