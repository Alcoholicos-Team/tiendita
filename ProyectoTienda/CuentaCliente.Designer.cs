namespace ProyectoTienda
{
    partial class fCuentaCliente
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
            this.ttMensajes = new System.Windows.Forms.ToolTip(this.components);
            this.errorDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboxCuentaCliente = new System.Windows.Forms.ComboBox();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.nudEdadCliente = new System.Windows.Forms.NumericUpDown();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.dtpFechaCliente = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // errorDatos
            // 
            this.errorDatos.ContainerControl = this;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnRegresar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(392, 193);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(122, 27);
            this.btnRegresar.TabIndex = 17;
            this.btnRegresar.Text = "Ventana Principal";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCrear.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(392, 108);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(122, 23);
            this.btnCrear.TabIndex = 16;
            this.btnCrear.Text = "Crear Cuenta";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Controls.Add(this.txtIDCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmboxCuentaCliente);
            this.groupBox1.Controls.Add(this.lblTipoCuenta);
            this.groupBox1.Controls.Add(this.nudEdadCliente);
            this.groupBox1.Controls.Add(this.txtCuenta);
            this.groupBox1.Controls.Add(this.txtContra);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.dtpFechaCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 281);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Datos";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Enabled = false;
            this.txtIDCliente.Location = new System.Drawing.Point(132, 26);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(204, 21);
            this.txtIDCliente.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID Cliente:";
            // 
            // cmboxCuentaCliente
            // 
            this.cmboxCuentaCliente.Enabled = false;
            this.cmboxCuentaCliente.FormattingEnabled = true;
            this.cmboxCuentaCliente.Location = new System.Drawing.Point(132, 246);
            this.cmboxCuentaCliente.Name = "cmboxCuentaCliente";
            this.cmboxCuentaCliente.Size = new System.Drawing.Size(121, 21);
            this.cmboxCuentaCliente.TabIndex = 11;
            this.cmboxCuentaCliente.Text = "Cliente";
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
            // nudEdadCliente
            // 
            this.nudEdadCliente.Location = new System.Drawing.Point(132, 205);
            this.nudEdadCliente.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudEdadCliente.Name = "nudEdadCliente";
            this.nudEdadCliente.Size = new System.Drawing.Size(50, 21);
            this.nudEdadCliente.TabIndex = 9;
            this.nudEdadCliente.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(132, 92);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(204, 21);
            this.txtCuenta.TabIndex = 8;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(132, 125);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(204, 21);
            this.txtContra.TabIndex = 7;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(132, 58);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(204, 21);
            this.txtNombreCliente.TabIndex = 5;
            // 
            // dtpFechaCliente
            // 
            this.dtpFechaCliente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCliente.Location = new System.Drawing.Point(132, 165);
            this.dtpFechaCliente.Name = "dtpFechaCliente";
            this.dtpFechaCliente.Size = new System.Drawing.Size(134, 21);
            this.dtpFechaCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Edad:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre Cuenta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnLimpiar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(392, 151);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(122, 26);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Lmpiar Datos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // fCuentaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(526, 363);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Name = "fCuentaCliente";
            this.Text = "Cuenta Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fCuentaCliente_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip ttMensajes;
        private System.Windows.Forms.ErrorProvider errorDatos;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboxCuentaCliente;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.NumericUpDown nudEdadCliente;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpiar;
    }
}