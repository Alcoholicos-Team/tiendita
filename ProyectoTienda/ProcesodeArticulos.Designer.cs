namespace ProyectoTienda
{
    partial class fProcesodeArticulos
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
            this.btnBuscarArt = new System.Windows.Forms.Button();
            this.btnEliminarArt = new System.Windows.Forms.Button();
            this.gboxArt = new System.Windows.Forms.GroupBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnActualizarArt = new System.Windows.Forms.Button();
            this.btnCargarVentana = new System.Windows.Forms.Button();
            this.btnCrearArt = new System.Windows.Forms.Button();
            this.dboxIngresoDatos = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtCodigoArt = new System.Windows.Forms.TextBox();
            this.txtNombreArt = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnLimpiarArts = new System.Windows.Forms.Button();
            this.gboxArt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.dboxIngresoDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscarArt
            // 
            this.btnBuscarArt.BackColor = System.Drawing.Color.Aquamarine;
            this.btnBuscarArt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarArt.Location = new System.Drawing.Point(378, 115);
            this.btnBuscarArt.Name = "btnBuscarArt";
            this.btnBuscarArt.Size = new System.Drawing.Size(122, 26);
            this.btnBuscarArt.TabIndex = 29;
            this.btnBuscarArt.Text = "Buscar Articulo";
            this.btnBuscarArt.UseVisualStyleBackColor = false;
            this.btnBuscarArt.Click += new System.EventHandler(this.btnBuscarArt_Click);
            // 
            // btnEliminarArt
            // 
            this.btnEliminarArt.BackColor = System.Drawing.Color.Aquamarine;
            this.btnEliminarArt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArt.Location = new System.Drawing.Point(378, 162);
            this.btnEliminarArt.Name = "btnEliminarArt";
            this.btnEliminarArt.Size = new System.Drawing.Size(122, 23);
            this.btnEliminarArt.TabIndex = 28;
            this.btnEliminarArt.Text = "Eliminar Articulo";
            this.btnEliminarArt.UseVisualStyleBackColor = false;
            this.btnEliminarArt.Click += new System.EventHandler(this.btnEliminarArt_Click);
            // 
            // gboxArt
            // 
            this.gboxArt.BackColor = System.Drawing.Color.CadetBlue;
            this.gboxArt.Controls.Add(this.dgvArticulos);
            this.gboxArt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxArt.Location = new System.Drawing.Point(12, 302);
            this.gboxArt.Name = "gboxArt";
            this.gboxArt.Size = new System.Drawing.Size(476, 188);
            this.gboxArt.TabIndex = 27;
            this.gboxArt.TabStop = false;
            this.gboxArt.Text = "Datos Articulos";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 19);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(458, 162);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellClick);
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentClick);
            // 
            // btnActualizarArt
            // 
            this.btnActualizarArt.BackColor = System.Drawing.Color.Aquamarine;
            this.btnActualizarArt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarArt.Location = new System.Drawing.Point(378, 68);
            this.btnActualizarArt.Name = "btnActualizarArt";
            this.btnActualizarArt.Size = new System.Drawing.Size(122, 23);
            this.btnActualizarArt.TabIndex = 26;
            this.btnActualizarArt.Text = "Actualizar Articulo";
            this.btnActualizarArt.UseVisualStyleBackColor = false;
            this.btnActualizarArt.Click += new System.EventHandler(this.btnActualizarArt_Click);
            // 
            // btnCargarVentana
            // 
            this.btnCargarVentana.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCargarVentana.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarVentana.Location = new System.Drawing.Point(378, 249);
            this.btnCargarVentana.Name = "btnCargarVentana";
            this.btnCargarVentana.Size = new System.Drawing.Size(122, 27);
            this.btnCargarVentana.TabIndex = 25;
            this.btnCargarVentana.Text = "Ventana Principal";
            this.btnCargarVentana.UseVisualStyleBackColor = false;
            this.btnCargarVentana.Click += new System.EventHandler(this.btnCargarVentana_Click);
            // 
            // btnCrearArt
            // 
            this.btnCrearArt.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCrearArt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearArt.Location = new System.Drawing.Point(378, 23);
            this.btnCrearArt.Name = "btnCrearArt";
            this.btnCrearArt.Size = new System.Drawing.Size(122, 23);
            this.btnCrearArt.TabIndex = 24;
            this.btnCrearArt.Text = "Nuevo Articulo";
            this.btnCrearArt.UseVisualStyleBackColor = false;
            this.btnCrearArt.Click += new System.EventHandler(this.btnCrearArt_Click);
            // 
            // dboxIngresoDatos
            // 
            this.dboxIngresoDatos.BackColor = System.Drawing.Color.CadetBlue;
            this.dboxIngresoDatos.Controls.Add(this.txtPrecio);
            this.dboxIngresoDatos.Controls.Add(this.txtDepartamento);
            this.dboxIngresoDatos.Controls.Add(this.txtID);
            this.dboxIngresoDatos.Controls.Add(this.lblID);
            this.dboxIngresoDatos.Controls.Add(this.txtCodigoArt);
            this.dboxIngresoDatos.Controls.Add(this.txtNombreArt);
            this.dboxIngresoDatos.Controls.Add(this.lblEdad);
            this.dboxIngresoDatos.Controls.Add(this.lblFecha);
            this.dboxIngresoDatos.Controls.Add(this.lblContraseña);
            this.dboxIngresoDatos.Controls.Add(this.lblNombre);
            this.dboxIngresoDatos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dboxIngresoDatos.ForeColor = System.Drawing.Color.Black;
            this.dboxIngresoDatos.Location = new System.Drawing.Point(12, 23);
            this.dboxIngresoDatos.Name = "dboxIngresoDatos";
            this.dboxIngresoDatos.Size = new System.Drawing.Size(360, 236);
            this.dboxIngresoDatos.TabIndex = 22;
            this.dboxIngresoDatos.TabStop = false;
            this.dboxIngresoDatos.Text = "Ingreso de Datos";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(132, 188);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(204, 21);
            this.txtPrecio.TabIndex = 15;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(132, 152);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(204, 21);
            this.txtDepartamento.TabIndex = 14;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(132, 45);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(204, 21);
            this.txtID.TabIndex = 13;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(9, 48);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(70, 13);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "ID Articulo:";
            // 
            // txtCodigoArt
            // 
            this.txtCodigoArt.Location = new System.Drawing.Point(132, 113);
            this.txtCodigoArt.Name = "txtCodigoArt";
            this.txtCodigoArt.Size = new System.Drawing.Size(204, 21);
            this.txtCodigoArt.TabIndex = 7;
            // 
            // txtNombreArt
            // 
            this.txtNombreArt.Location = new System.Drawing.Point(132, 77);
            this.txtNombreArt.Name = "txtNombreArt";
            this.txtNombreArt.Size = new System.Drawing.Size(204, 21);
            this.txtNombreArt.TabIndex = 5;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(9, 191);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(45, 13);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Precio:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(9, 155);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(93, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Departamento:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(9, 116);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(95, 13);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Codigo Articulo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(101, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre Articulo:";
            // 
            // btnLimpiarArts
            // 
            this.btnLimpiarArts.BackColor = System.Drawing.Color.Aquamarine;
            this.btnLimpiarArts.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarArts.Location = new System.Drawing.Point(378, 207);
            this.btnLimpiarArts.Name = "btnLimpiarArts";
            this.btnLimpiarArts.Size = new System.Drawing.Size(122, 26);
            this.btnLimpiarArts.TabIndex = 23;
            this.btnLimpiarArts.Text = "Lmpiar Datos";
            this.btnLimpiarArts.UseVisualStyleBackColor = false;
            this.btnLimpiarArts.Click += new System.EventHandler(this.btnLimpiarArts_Click);
            // 
            // fProcesodeArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(512, 512);
            this.Controls.Add(this.btnBuscarArt);
            this.Controls.Add(this.btnEliminarArt);
            this.Controls.Add(this.gboxArt);
            this.Controls.Add(this.btnActualizarArt);
            this.Controls.Add(this.btnCargarVentana);
            this.Controls.Add(this.btnCrearArt);
            this.Controls.Add(this.dboxIngresoDatos);
            this.Controls.Add(this.btnLimpiarArts);
            this.Name = "fProcesodeArticulos";
            this.Text = "Procesos de Articulos";
            this.Load += new System.EventHandler(this.fProcesodeArticulos_Load);
            this.gboxArt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.dboxIngresoDatos.ResumeLayout(false);
            this.dboxIngresoDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarArt;
        private System.Windows.Forms.Button btnEliminarArt;
        private System.Windows.Forms.GroupBox gboxArt;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnActualizarArt;
        private System.Windows.Forms.Button btnCargarVentana;
        private System.Windows.Forms.Button btnCrearArt;
        private System.Windows.Forms.GroupBox dboxIngresoDatos;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtCodigoArt;
        private System.Windows.Forms.TextBox txtNombreArt;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnLimpiarArts;
    }
}