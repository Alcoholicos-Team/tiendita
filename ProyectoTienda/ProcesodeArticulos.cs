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
    public partial class fProcesodeArticulos : Form
    {
        public fProcesodeArticulos()
        {
            InitializeComponent();
        }

        ProcesosArticulos opciones = new ProcesosArticulos();

        private void btnCrearArt_Click(object sender, EventArgs e)
        {
            if (opciones.Insertar(txtID.Text,txtNombreArt.Text, txtCodigoArt.Text, txtDepartamento.Text, txtPrecio.Text))
            {
                MessageBox.Show("Datos agregados Correctamente", "Agregar Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvArticulos.DataSource = opciones.MostrarDatos();
            }
            else
            {
                MessageBox.Show("No se han podido agregar los datos", "Error Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargarVentana_Click(object sender, EventArgs e)
        {
            string cmd = "Select * From Usuarios where ID_Uusarios=" + fLogin.codigo;
            DataSet DS = Utilidades.Ejecutar(cmd);
            string TipoCuenta = DS.Tables[0].Rows[0]["Etado_Usuario"].ToString().Trim();
            if (TipoCuenta == "Usuario")
            {
                fProcesosUsuarios regresar = new fProcesosUsuarios();
                this.Hide();
                regresar.ShowDialog();
            }
            else if (TipoCuenta == "Administrador")
            {
                fProcesosEleccion regresar = new fProcesosEleccion();
                this.Hide();
                regresar.ShowDialog();
            }
        }

        private void btnLimpiarArts_Click(object sender, EventArgs e)
        {
            txtCodigoArt.Clear();
            txtDepartamento.Clear();
            txtID.Clear();
            txtNombreArt.Clear();
            txtPrecio.Clear();
        }

        private void btnEliminarArt_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("No se ha podido eliminar el articulo", "Error", 0, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Esta seguro de eliminar este articulo?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcion == DialogResult.Yes)
                {
                    if (opciones.Eliminar(txtID.Text))
                    {
                        MessageBox.Show("Articulo Eliminado", "Eliminar Articulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       dgvArticulos.DataSource = opciones.MostrarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Error al borrar el articulo", "Error de Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBuscarArt_Click(object sender, EventArgs e)
        {
            if (txtNombreArt.Text != string.Empty || txtCodigoArt.Text == string.Empty)
            {
                dgvArticulos.DataSource = opciones.BuscarDatos(txtNombreArt.Text, txtCodigoArt.Text);
            }
            else
            {
                MessageBox.Show("No se ha podido mostrar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarArt_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("No se ha podido actualizar los Datos", "Error actualización de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Esta seguro de actualizar los datos ingresados", "Comprovación de Instrucción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcion == DialogResult.Yes)
                {
                    if (opciones.Actualizar(txtID.Text,txtNombreArt.Text,txtCodigoArt.Text,txtDepartamento.Text,txtPrecio.Text))
                    {
                        MessageBox.Show("Datos Actualizados Correctamente", "Agregar Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvArticulos.DataSource = opciones.MostrarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar los datos", "Error Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void fProcesodeArticulos_Load(object sender, EventArgs e)
        {
            dgvArticulos.DataSource = opciones.MostrarDatos();
        }
        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvArticulos.Rows[e.RowIndex];
            txtID.Text = Convert.ToString(fila.Cells[0].Value);
            txtNombreArt.Text = Convert.ToString(fila.Cells[1].Value);
            txtCodigoArt.Text = Convert.ToString(fila.Cells[2].Value);
            txtDepartamento.Text = Convert.ToString(fila.Cells[3].Value);
            txtPrecio.Text = Convert.ToString(fila.Cells[4].Value);
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
