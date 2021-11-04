using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;

namespace ProyectoTienda
{
    public partial class fProcesosEleccion : Form
    { 
        public fProcesosEleccion()
        {
            InitializeComponent();
            this.ttMsm.SetToolTip(pbocArticulos, "Prsione para entrar al areá de Compra");
            this.ttMsm.SetToolTip(pboxAdministracion, "Presione para entrar al areá de Administración Bancaria");
            this.ttMsm.SetToolTip(pboxClientes, "Preseone para entrar al areá de Clientes");
            this.ttMsm.SetToolTip(pboxRendimiento, "Presione para entrar al areá de Rendimiento");
            this.ttMsm.SetToolTip(pboxUusarios, "Presione si desea agregar un Nuevo Usuario");
            this.ttMsm.SetToolTip(pboxGanancias, "Presione para entrar en el areá de Ganancias");
        }

        private void fProcesosEleccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pboxUusarios_Click(object sender, EventArgs e)
        {
            fCreaciondeCuenta abrir = new fCreaciondeCuenta();
            this.Hide();
            abrir.ShowDialog();
        }

        private void pboxClientes_Click(object sender, EventArgs e)
        {
            /*fDatosClientes abrir = new fDatosClientes();
            this.Hide();
            abrir.ShowDialog();*/
        }

        private void fProcesosEleccion_Load(object sender, EventArgs e)
        {

        }

        private void pboxRendimiento_Click(object sender, EventArgs e)
        {

        }

        private void pboxAdministracion_Click(object sender, EventArgs e)
        {

        }

        private void pbocArticulos_Click(object sender, EventArgs e)
        {
            fProcesodeArticulos abrir = new fProcesodeArticulos();
            this.Hide();
            abrir.ShowDialog();
        }

        private void pboxGanancias_Click(object sender, EventArgs e)
        {

        }
    }
}
