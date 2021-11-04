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
    public partial class fCreaciondeCuenta : Form
    {
        public fCreaciondeCuenta()
        {
            InitializeComponent();
            this.ttMensajes.SetToolTip(txtID,"Identificador de la Cuenta");
            this.ttMensajes.SetToolTip(txtNombre,"Nombre del Usuario u Administrador");
            this.ttMensajes.SetToolTip(txtNOmbreCuenta,"Nombre de la cuenta");
            this.ttMensajes.SetToolTip(txtContraseña,"Contraseña de la cuenta");
            this.ttMensajes.SetToolTip(nudEdad,"Edad del Usuario u Administrador");
            this.ttMensajes.SetToolTip(cmboxTipodeCuenta,"Tipo de Cuenta");
            this.ttMensajes.SetToolTip(dtpFechaUsuario,"Fecha de nacimiento del Usuario u Administrador");
            this.ttMensajes.SetToolTip(btnActualizar,"Presione para actualizar los datos");
            this.ttMensajes.SetToolTip(btnBuscar,"Presione para buscar segun el Nombre o la Cuenta");
            this.ttMensajes.SetToolTip(btnLimpiar,"Presione para limpiar los datos");
            this.ttMensajes.SetToolTip(btnEliminar,"Presione si desea eliminar alguna cuenta");
            this.ttMensajes.SetToolTip(btnCrear,"Presione si desea agregar alguna cuenta");
            this.ttMensajes.SetToolTip(btnCargarLogin, "Presione para regresar");
        }

        //Llamada a la clase procesos y creacion del objeto opciones
        Procesos opciones = new Procesos();

        //Metodo para mostrar un error
        private bool Error()
        {
            bool noError = true;
            if(txtNombre.Text == string.Empty)
            {
                errorDatos.SetError(txtNombre, "Ingrese un Nombre");
                noError = false;
            }
            else if (txtNOmbreCuenta.Text == string.Empty)
            {
                errorDatos.Clear();
                errorDatos.SetError(txtNOmbreCuenta,"Ingrese el Nombre de la Cuenta");
                noError = false;
            }
            else if(txtContraseña.Text == string.Empty)
            {
                errorDatos.Clear();
                errorDatos.SetError(txtContraseña, "Ingrese una contraseña");
                noError = false;
            }
            else if(cmboxTipodeCuenta.Text == "Seleccione" || cmboxTipodeCuenta.Text == string.Empty)
            {
                errorDatos.Clear();
                errorDatos.SetError(cmboxTipodeCuenta, "seleccione una opción");
                noError = false;
            }
            return noError;
        }

        //Boton para crear cuenta
        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (Error())
            {
                errorDatos.Clear();
                txtID.Text = dgvDatosCuentas.Rows.Count.ToString();
                if (opciones.Insertar(txtID.Text, txtNombre.Text, txtNOmbreCuenta.Text, txtContraseña.Text, dtpFechaUsuario.Text, nudEdad.Value.ToString(), cmboxTipodeCuenta.Text))
                {
                    MessageBox.Show("Datos agregados Correctamente", "Agregar Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDatosCuentas.DataSource = opciones.MostrarDatos();
                }
                else
                {
                    MessageBox.Show("No se han podido agregar los datos", "Error Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Evento de cerrar el formulario
        private void fCreaciondeCuenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Evento de carga del formulario
        private void fCreaciondeCuenta_Load(object sender, EventArgs e)
        {
            //Rellenar los datos segun la cuenta ingresada
            string cmd = "Select * From Usuarios where ID_Uusarios=" + fLogin.codigo;
            DataSet DS = Utilidades.Ejecutar(cmd);
            txtID.Text = DS.Tables[0].Rows[0]["ID_Uusarios"].ToString();
            txtNombre.Text = DS.Tables[0].Rows[0]["Numbre_Usuario"].ToString();
            txtNOmbreCuenta.Text = DS.Tables[0].Rows[0]["Usuario"].ToString();
            txtContraseña.Text = DS.Tables[0].Rows[0]["Contraseña"].ToString();
            dtpFechaUsuario.Text = DS.Tables[0].Rows[0]["Fecha_Nacimiento"].ToString();
            nudEdad.Value = Convert.ToInt32(DS.Tables[0].Rows[0]["Edad"]);
            cmboxTipodeCuenta.Text = DS.Tables[0].Rows[0]["Etado_Usuario"].ToString().Trim();
            //Mostrar datos en la tabla
            dgvDatosCuentas.DataSource = opciones.MostrarDatos();
            
        }

        //Boton para regresar a la ventana de procesos segun sea el tipo de cuenta
        private void btnCargarLogin_Click(object sender, EventArgs e)
        {
            string cmd = "Select * From Usuarios where ID_Uusarios=" + fLogin.codigo;
            DataSet DS = Utilidades.Ejecutar(cmd);
            fProcesosEleccion regresar = new fProcesosEleccion();
            this.Hide();
            regresar.ShowDialog();
        }

        //Boton para actualizar datos de la cuenta
        private void btnActualizar_Click(object sender, EventArgs e)
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
                    if (opciones.Actualizar(txtID.Text, txtNombre.Text, txtNOmbreCuenta.Text, txtContraseña.Text, dtpFechaUsuario.Text, nudEdad.Value.ToString(), cmboxTipodeCuenta.Text))
                    {
                        MessageBox.Show("Datos Actualizados Correctamente", "Agregar Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDatosCuentas.DataSource = opciones.MostrarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar los datos", "Error Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //muestra los datos de la base de datos en una ventana
        private void dgvDatosCuentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvDatosCuentas.Rows[e.RowIndex];
            txtID.Text = Convert.ToString(fila.Cells[0].Value);
            txtNombre.Text = Convert.ToString(fila.Cells[1].Value);
            txtNOmbreCuenta.Text = Convert.ToString(fila.Cells[2].Value);
            txtContraseña.Text = Convert.ToString(fila.Cells[3].Value);
            dtpFechaUsuario.Text = Convert.ToString(fila.Cells[4].Value);
            nudEdad.Value = Convert.ToInt32(fila.Cells[5].Value);
            cmboxTipodeCuenta.Text = Convert.ToString(fila.Cells[6].Value);
        }

        //Boton para eliminar la cuenta de la base de datos
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("No se ha podido eliminar la cuenta", "Error", 0, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Esta seguro de eliminar está cuenta?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcion == DialogResult.Yes)
                {
                    if (opciones.Eliminar(txtID.Text))
                    {
                        MessageBox.Show("Cuenta Eliminada", "Eliminar Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDatosCuentas.DataSource = opciones.MostrarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Error al borrar la cuenta", "Error de Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Boton para buscar cuentas
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != string.Empty || txtNOmbreCuenta.Text != string.Empty || cmboxTipodeCuenta.Text != string.Empty)
            {
                dgvDatosCuentas.DataSource = opciones.BuscarDatos(txtNombre.Text, txtNOmbreCuenta.Text, cmboxTipodeCuenta.Text);
            }
            else
            {
                MessageBox.Show("No se ha podido mostrar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Boton para Limpiar los objetos del formulario
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtContraseña.Clear();
            txtID.Clear();
            txtNombre.Clear();
            txtNOmbreCuenta.Clear();
            nudEdad.Value = 18;
            cmboxTipodeCuenta.ResetText();
            dtpFechaUsuario.ResetText();
            errorDatos.Clear();
        }
    }
}
