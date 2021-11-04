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
    public partial class fVerificacionCuenta : Form
    {
        public fVerificacionCuenta()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(txtVerificarCuenta, "Ingrese su cuenta");
            this.ttMensaje.SetToolTip(btnIngresar,"Presionde si desea ingresar a la pagina de cambio de cuenta");
            this.ttMensaje.SetToolTip(btnRegresar,"Prseione si desea regresar a la ventana de ingreso");
        }

        public static String cadena = "";

        //metodo caragar del formulario
        private void fErrorContra_Load(object sender, EventArgs e)
        {
            txtVerificarCuenta.Focus();
        }

        //Metodo para cerrar la aplicación del evento closed del formulario
        private void fErrorContra_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Metodo para cargar el formulario del cambio de contraseña verificanto los datos digitados
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("Select * FROM Usuarios WHERE Usuario='{0}'", txtVerificarCuenta.Text.Trim());
                DataSet DS = Utilidades.Ejecutar(cmd);
                cadena = DS.Tables[0].Rows[0]["ID_Uusarios"].ToString().Trim();
                string usuario = DS.Tables[0].Rows[0]["Usuario"].ToString().Trim();
                if ((usuario == txtVerificarCuenta.Text.Trim()))
                {
                    fContraseña entrar = new fContraseña();
                    this.Hide();
                    entrar.ShowDialog();
                }
            }
            catch (Exception)
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Cuenta Incorrecta... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVerificarCuenta.Clear();
            }

        }

        //Metodo para regresar del boton btnRegresar
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            fLogin regreso = new fLogin();
            this.Hide();
            regreso.ShowDialog();
        }
    }
}
