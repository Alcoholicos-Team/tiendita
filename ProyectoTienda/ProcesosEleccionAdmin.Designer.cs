namespace ProyectoTienda
{
    partial class fProcesosEleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fProcesosEleccion));
            this.pboxClientes = new System.Windows.Forms.PictureBox();
            this.pbocArticulos = new System.Windows.Forms.PictureBox();
            this.pboxRendimiento = new System.Windows.Forms.PictureBox();
            this.pboxUusarios = new System.Windows.Forms.PictureBox();
            this.pboxAdministracion = new System.Windows.Forms.PictureBox();
            this.ttMsm = new System.Windows.Forms.ToolTip(this.components);
            this.pboxGanancias = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbocArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRendimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUusarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAdministracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxGanancias)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxClientes
            // 
            this.pboxClientes.Image = ((System.Drawing.Image)(resources.GetObject("pboxClientes.Image")));
            this.pboxClientes.Location = new System.Drawing.Point(36, 47);
            this.pboxClientes.Name = "pboxClientes";
            this.pboxClientes.Size = new System.Drawing.Size(110, 123);
            this.pboxClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxClientes.TabIndex = 0;
            this.pboxClientes.TabStop = false;
            this.pboxClientes.Click += new System.EventHandler(this.pboxClientes_Click);
            // 
            // pbocArticulos
            // 
            this.pbocArticulos.Image = ((System.Drawing.Image)(resources.GetObject("pbocArticulos.Image")));
            this.pbocArticulos.Location = new System.Drawing.Point(297, 47);
            this.pbocArticulos.Name = "pbocArticulos";
            this.pbocArticulos.Size = new System.Drawing.Size(110, 123);
            this.pbocArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbocArticulos.TabIndex = 1;
            this.pbocArticulos.TabStop = false;
            this.pbocArticulos.Click += new System.EventHandler(this.pbocArticulos_Click);
            // 
            // pboxRendimiento
            // 
            this.pboxRendimiento.Image = ((System.Drawing.Image)(resources.GetObject("pboxRendimiento.Image")));
            this.pboxRendimiento.Location = new System.Drawing.Point(166, 47);
            this.pboxRendimiento.Name = "pboxRendimiento";
            this.pboxRendimiento.Size = new System.Drawing.Size(110, 123);
            this.pboxRendimiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxRendimiento.TabIndex = 2;
            this.pboxRendimiento.TabStop = false;
            this.pboxRendimiento.Click += new System.EventHandler(this.pboxRendimiento_Click);
            // 
            // pboxUusarios
            // 
            this.pboxUusarios.Image = ((System.Drawing.Image)(resources.GetObject("pboxUusarios.Image")));
            this.pboxUusarios.Location = new System.Drawing.Point(297, 212);
            this.pboxUusarios.Name = "pboxUusarios";
            this.pboxUusarios.Size = new System.Drawing.Size(110, 123);
            this.pboxUusarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxUusarios.TabIndex = 3;
            this.pboxUusarios.TabStop = false;
            this.pboxUusarios.Click += new System.EventHandler(this.pboxUusarios_Click);
            // 
            // pboxAdministracion
            // 
            this.pboxAdministracion.Image = ((System.Drawing.Image)(resources.GetObject("pboxAdministracion.Image")));
            this.pboxAdministracion.Location = new System.Drawing.Point(36, 212);
            this.pboxAdministracion.Name = "pboxAdministracion";
            this.pboxAdministracion.Size = new System.Drawing.Size(110, 123);
            this.pboxAdministracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAdministracion.TabIndex = 4;
            this.pboxAdministracion.TabStop = false;
            this.pboxAdministracion.Click += new System.EventHandler(this.pboxAdministracion_Click);
            // 
            // pboxGanancias
            // 
            this.pboxGanancias.Image = ((System.Drawing.Image)(resources.GetObject("pboxGanancias.Image")));
            this.pboxGanancias.Location = new System.Drawing.Point(166, 212);
            this.pboxGanancias.Name = "pboxGanancias";
            this.pboxGanancias.Size = new System.Drawing.Size(110, 123);
            this.pboxGanancias.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxGanancias.TabIndex = 5;
            this.pboxGanancias.TabStop = false;
            this.pboxGanancias.Click += new System.EventHandler(this.pboxGanancias_Click);
            // 
            // fProcesosEleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(449, 392);
            this.Controls.Add(this.pboxGanancias);
            this.Controls.Add(this.pboxAdministracion);
            this.Controls.Add(this.pboxUusarios);
            this.Controls.Add(this.pboxRendimiento);
            this.Controls.Add(this.pbocArticulos);
            this.Controls.Add(this.pboxClientes);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "fProcesosEleccion";
            this.Text = "Elección de Procesos para Administradores";
            this.Load += new System.EventHandler(this.fProcesosEleccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbocArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRendimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUusarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAdministracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxGanancias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxClientes;
        private System.Windows.Forms.PictureBox pbocArticulos;
        private System.Windows.Forms.PictureBox pboxRendimiento;
        private System.Windows.Forms.PictureBox pboxUusarios;
        private System.Windows.Forms.PictureBox pboxAdministracion;
        private System.Windows.Forms.ToolTip ttMsm;
        private System.Windows.Forms.PictureBox pboxGanancias;
    }
}