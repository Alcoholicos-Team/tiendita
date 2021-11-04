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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            this.ttMensajes.SetToolTip(txtContraseña,"Ingrese contraseña");
            this.ttMensajes.SetToolTip(txtCuenta, "Ingrese Nombre de Usuario");
            this.ttMensajes.SetToolTip(btnIngresar, "Presione para ingresar a la aplicación");
            this.ttMensajes.SetToolTip(btnSalir, "Presione para salir");
            this.ttMensajes.SetToolTip(cmboxTipoUsuario, "Seleccione tipo de Cuenta");
        }
        Procesos opciones = new Procesos();
        public static String codigo = "";

        //Metodo de Error
        private bool Error()
        {
            bool noError = true;
            if (txtCuenta.Text == string.Empty)
            {
                errorpIngresodeDatos.Clear();
                errorpIngresodeDatos.SetError(txtCuenta, "Ingrese un usuario");
                noError = false;
            }
           else if (txtContraseña.Text == string.Empty)
            {
                errorpIngresodeDatos.Clear();
                errorpIngresodeDatos.SetError(txtContraseña, "Ingrese una contraseña");
                noError = false;
            }
             else if (cmboxTipoUsuario.Text == "Seleccione" || cmboxTipoUsuario.Text == string.Empty)
            {
                errorpIngresodeDatos.Clear();
                errorpIngresodeDatos.SetError(cmboxTipoUsuario,"Seleccione una opción");
                noError = false;
            }
            return noError;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Esta seguro que desea Salir", "Ventan de Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(opcion == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            if (Error())
            {
                errorpIngresodeDatos.Clear();
               try
                {
                    string cmd = string.Format("Select * FROM Usuarios WHERE Usuario='{0}' AND Contraseña='{1}' AND Etado_Usuario='{2}'", txtCuenta.Text.Trim(), txtContraseña.Text.Trim(), cmboxTipoUsuario.Text.Trim());
                    DataSet DS = Utilidades.Ejecutar(cmd);
                    codigo = DS.Tables[0].Rows[0]["ID_Uusarios"].ToString().Trim();
                    string cuenta = DS.Tables[0].Rows[0]["Usuario"].ToString().Trim();
                    string contra = DS.Tables[0].Rows[0]["Contraseña"].ToString().Trim();
                    string TipoCuenta = DS.Tables[0].Rows[0]["Etado_Usuario"].ToString().Trim();
                    
                    //Condición de vireficación de datos
                    if ((cuenta == txtCuenta.Text.Trim()) && (contra == txtContraseña.Text.Trim()) && (TipoCuenta == cmboxTipoUsuario.Text.Trim()))
                    {
                        if(cmboxTipoUsuario.Text == "Administrador")
                        {
                            fProcesosEleccion abrirVentanaAdmin = new fProcesosEleccion();
                            opcion = MessageBox.Show("Datos  ingresados correctamente", "Verificació de Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            if (opcion == DialogResult.OK)
                            {
                                this.Hide();
                                abrirVentanaAdmin.ShowDialog();
                            }
                        }
                        else if(cmboxTipoUsuario.Text == "Usuario")
                        {
                           fProcesosUsuarios abrirVentanaUsuario = new fProcesosUsuarios();
                            opcion = MessageBox.Show("Datos  ingresados correctamente", "Verificació de Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            if (opcion == DialogResult.OK)
                            {
                                this.Hide();
                                abrirVentanaUsuario.ShowDialog();
                            }
                        }
                        else if(cmboxTipoUsuario.Text == "Cliente")
                        {
                            fArticulos abrirVentanaArt = new fArticulos();
                            opcion = MessageBox.Show("Datos  ingresados correctamente", "Verificació de Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            if (opcion == DialogResult.OK)
                            {
                                this.Hide();
                                abrirVentanaArt.ShowDialog();
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    opcion = MessageBox.Show("Cuenta o Contraseña Incorrecta...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCuenta.Clear();
                    txtContraseña.Clear();
                    cmboxTipoUsuario.ResetText();
                    llblContraOlvidada.Enabled = true;
                    llblContraOlvidada.Visible = true;
                }
            }
        }

        private void fIngresodeCuenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            string cmd = "Select * From Usuarios Where ID_Uusarios= " + fLogin.codigo;
        }

        private void llblContraOlvidada_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fVerificacionCuenta abrrir = new fVerificacionCuenta();
            this.Hide();
            abrrir.ShowDialog();
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            fCuentaCliente abrir = new fCuentaCliente();
            this.Hide();
            abrir.ShowDialog();
        }
    }
}
