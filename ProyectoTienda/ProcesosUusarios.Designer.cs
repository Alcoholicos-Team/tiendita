namespace ProyectoTienda
{
    partial class fProcesosUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fProcesosUsuarios));
            this.pboxAdministracion = new System.Windows.Forms.PictureBox();
            this.pboxRenEnVentas = new System.Windows.Forms.PictureBox();
            this.pbocArticulos = new System.Windows.Forms.PictureBox();
            this.pboxClientes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAdministracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRenEnVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbocArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogin
            // 
            // 
            // pboxAdministracion
            // 
            this.pboxAdministracion.Image = ((System.Drawing.Image)(resources.GetObject("pboxAdministracion.Image")));
            this.pboxAdministracion.Location = new System.Drawing.Point(102, 230);
            this.pboxAdministracion.Name = "pboxAdministracion";
            this.pboxAdministracion.Size = new System.Drawing.Size(110, 123);
            this.pboxAdministracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAdministracion.TabIndex = 9;
            this.pboxAdministracion.TabStop = false;
            this.pboxAdministracion.Click += new System.EventHandler(this.pboxAdministracion_Click);
            // 
            // pboxRenEnVentas
            // 
            this.pboxRenEnVentas.Image = ((System.Drawing.Image)(resources.GetObject("pboxRenEnVentas.Image")));
            this.pboxRenEnVentas.Location = new System.Drawing.Point(248, 221);
            this.pboxRenEnVentas.Name = "pboxRenEnVentas";
            this.pboxRenEnVentas.Size = new System.Drawing.Size(110, 123);
            this.pboxRenEnVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxRenEnVentas.TabIndex = 7;
            this.pboxRenEnVentas.TabStop = false;
            this.pboxRenEnVentas.Click += new System.EventHandler(this.pboxRenEnVentas_Click);
            // 
            // pbocArticulos
            // 
            this.pbocArticulos.Image = ((System.Drawing.Image)(resources.GetObject("pbocArticulos.Image")));
            this.pbocArticulos.Location = new System.Drawing.Point(248, 65);
            this.pbocArticulos.Name = "pbocArticulos";
            this.pbocArticulos.Size = new System.Drawing.Size(110, 123);
            this.pbocArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbocArticulos.TabIndex = 6;
            this.pbocArticulos.TabStop = false;
            this.pbocArticulos.Click += new System.EventHandler(this.pbocArticulos_Click);
            // 
            // pboxClientes
            // 
            this.pboxClientes.Image = ((System.Drawing.Image)(resources.GetObject("pboxClientes.Image")));
            this.pboxClientes.Location = new System.Drawing.Point(102, 65);
            this.pboxClientes.Name = "pboxClientes";
            this.pboxClientes.Size = new System.Drawing.Size(110, 123);
            this.pboxClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxClientes.TabIndex = 5;
            this.pboxClientes.TabStop = false;
            this.pboxClientes.Click += new System.EventHandler(this.pboxClientes_Click);
            // 
            // fProcesosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(449, 392);
            this.Controls.Add(this.pboxAdministracion);
            this.Controls.Add(this.pboxRenEnVentas);
            this.Controls.Add(this.pbocArticulos);
            this.Controls.Add(this.pboxClientes);
            this.Name = "fProcesosUsuarios";
            this.Text = "Procesos Usuarios";
            this.Load += new System.EventHandler(this.fProcesosUsuarios_Load);
            this.Controls.SetChildIndex(this.pboxClientes, 0);
            this.Controls.SetChildIndex(this.pbocArticulos, 0);
            this.Controls.SetChildIndex(this.pboxRenEnVentas, 0);
            this.Controls.SetChildIndex(this.pboxAdministracion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pboxAdministracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRenEnVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbocArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxAdministracion;
        private System.Windows.Forms.PictureBox pboxRenEnVentas;
        private System.Windows.Forms.PictureBox pbocArticulos;
        private System.Windows.Forms.PictureBox pboxClientes;
    }
}