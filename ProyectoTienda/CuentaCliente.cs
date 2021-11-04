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
    public partial class fCuentaCliente : Form
    {
        public fCuentaCliente()
        {
            InitializeComponent();
            this.ttMensajes.SetToolTip(txtIDCliente,"Identificador de la cuenta , No se debe alterar este campo");
            this.ttMensajes.SetToolTip(txtNombreCliente,"Ingrese su Nombre");
            this.ttMensajes.SetToolTip(txtCuenta,"Ingrese un nombre para su cuenta");
            this.ttMensajes.SetToolTip(txtContra,"Ingrese una contraseña para su cuenta");
            this.ttMensajes.SetToolTip(dtpFechaCliente,"Ingrese su fecha de nacimiento");
            this.ttMensajes.SetToolTip(nudEdadCliente,"Ingrse su edad");
            this.ttMensajes.SetToolTip(cmboxCuentaCliente,"Tipo de cuenta, Este campo no se debe modificar");
            this.ttMensajes.SetToolTip(btnCrear,"Prseione para crear la cuenta");
            this.ttMensajes.SetToolTip(btnLimpiar,"Presione para limpiar los campos");
            this.ttMensajes.SetToolTip(btnRegresar,"Si desea regresar a la ventana de ingreso presione este boton");
        }

        //Creación del metodo constructor y creación del objeto opciones
        Procesos opciones = new Procesos();

        //Metodo para verificar los errores
        private bool Error()
        {
            int convercion;
            bool noError = true;
            if (txtNombreCliente.Text == string.Empty)
            {
                errorDatos.Clear();
                errorDatos.SetError(txtNombreCliente, "Ingrese un nombre");
                noError = false;
            }
            else if (txtCuenta.Text == string.Empty)
            {
                errorDatos.Clear();
                errorDatos.SetError(txtCuenta, "Ingrese un nombre de cuenta");
                noError = false;
            }
            else if (txtContra.Text == string.Empty)
            {
                errorDatos.SetError(txtContra, "Ingrese una contraseña");
                noError = false;
            }
            else if (nudEdadCliente.Value < 18 || !(int.TryParse(nudEdadCliente.Value.ToString(), out convercion)))
            {
                errorDatos.Clear();
                errorDatos.SetError(nudEdadCliente, "Ingrese una edad valida");
                noError = false;
            }
            return noError;
        }

        //Metodo para cerrar la ventana
        private void fCuentaCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //metodo del boton, para regresar al fLogin
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            fLogin regresar = new fLogin();
            this.Hide();
            regresar.ShowDialog();
        }

        //Metodo limpara limpiar los datos, del evento clivk del boton tbnLimpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            errorDatos.Clear();
            txtCuenta.Clear();
            txtIDCliente.Clear();
            txtNombreCliente.Clear();
            txtContra.Clear();
            dtpFechaCliente.ResetText();
            nudEdadCliente.Value = 18;
        }

        //metodo del para crear una cuenta de tipo cliente del boton btnCrear
        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            if (Error())
            {
                errorDatos.Clear();
                DialogResult opc;
                if (opciones.Insertar(txtIDCliente.Text, txtNombreCliente.Text, txtCuenta.Text, txtContra.Text, dtpFechaCliente.Text, nudEdadCliente.Value.ToString(), cmboxCuentaCliente.Text))
                {
                    opc = MessageBox.Show("Datos guardados correctamente", "Agregar datos", 0, MessageBoxIcon.Information);
                    if (opc == DialogResult.OK)
                    {
                        txtContra.Clear();
                        txtIDCliente.Clear();
                        txtNombreCliente.Clear();
                        txtCuenta.Clear();
                        dtpFechaCliente.ResetText();
                        cmboxCuentaCliente.ResetText();
                        nudEdadCliente.Value = 18;
                        fLogin reg = new fLogin();
                        this.Hide();
                        reg.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("No se ha podido crear la cuenta", "Error", 0, MessageBoxIcon.Error);
                }
            }
        }
    }
}
