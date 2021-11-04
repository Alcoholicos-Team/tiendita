using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTienda
{
    public partial class fProcesosUsuarios : Form
    {
        public fProcesosUsuarios()
        {
            InitializeComponent();
        }

        private void pboxClientes_Click(object sender, EventArgs e)
        {
            //fDatosClientes abrir = new fDatosClientes();
            this.Hide();
            //.ShowDialog();
        }

        private void pboxRenEnVentas_Click(object sender, EventArgs e)
        {

        }

        private void pbocArticulos_Click(object sender, EventArgs e)
        {
            fProcesodeArticulos abrir = new fProcesodeArticulos();
            this.Hide();
            abrir.ShowDialog();
        }

        private void pboxAdministracion_Click(object sender, EventArgs e)
        {

        }

        private void fProcesosUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
