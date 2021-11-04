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
    public partial class fContraseña : Form
    {
        public fContraseña()
        {
            InitializeComponent();
        }

        Procesos opcion = new Procesos();

        private void btnCargarLogin_Click(object sender, EventArgs e)
        {
            fLogin regresar = new fLogin();
            this.Hide();
            regresar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fContraseña_Load(object sender, EventArgs e)
        {
            string cmd = "Select * From Usuarios where ID_Uusarios=" + fVerificacionCuenta.cadena;
            DataSet DS = Utilidades.Ejecutar(cmd);
            txtIDCuenta.Text = DS.Tables[0].Rows[0]["ID_Uusarios"].ToString();
            txtNombre.Text = DS.Tables[0].Rows[0]["Numbre_Usuario"].ToString();
            txtCuentas.Text = DS.Tables[0].Rows[0]["Usuario"].ToString();
            txtContraseña.Text = DS.Tables[0].Rows[0]["Contraseña"].ToString();
            dtpFechaUsuario.Text = DS.Tables[0].Rows[0]["Fecha_Nacimiento"].ToString();
            nudEdad.Value = Convert.ToInt32(DS.Tables[0].Rows[0]["Edad"]);
            cmboxTipodeCuenta.Text = DS.Tables[0].Rows[0]["Etado_Usuario"].ToString().Trim();

        }

        private void btnContraseña_Click(object sender, EventArgs e)
        {
            if (!(txtContraseña.Text == string.Empty))
            {
                DialogResult opciones;
                opciones = MessageBox.Show("Esta seguro de cambiar la contraseña", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opciones == DialogResult.Yes)
                {
                    if (opcion.Actualizar(txtIDCuenta.Text, txtNombre.Text, txtCuentas.Text, txtContraseña.Text, dtpFechaUsuario.Text, nudEdad.Value.ToString(), cmboxTipodeCuenta.Text))
                    {
                        MessageBox.Show("Contraseña actualizada correctamente", "Verificar Acción", 0, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error de datos, favor llene los cuadros de texto", "Error", 0, MessageBoxIcon.Error);
            }
        }
    }
}
