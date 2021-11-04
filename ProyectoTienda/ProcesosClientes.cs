using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoTienda
{
    class ProcesosClientes
    {
        //cadena de conexión
        SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-TORUÑO; Initial Catalog = ProyectoTiendita; Integrated Security = True");
        //guarda varias tablas y sirve para mostrar datos
        DataSet ds;

        public DataTable MostrarDatos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("Select * from Clientes",conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "Tabla");
            conexion.Close();
            return ds.Tables["Tabla"];
        } 

        public DataTable BuscarDatos(string Nombre,string Cuenta)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Select * from Clientes where Nombre like '%{0}%' OR Cuenta like '%{1}%'", Nombre,Cuenta),conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "Tabla");
            conexion.Close();
            return ds.Tables["Tabla"];
        }

        public bool Insertar(string ID_Cliente, string Nombre, string Edad, string Cuenta, string Contraseña, string Estado_civil)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Insert into Clientes values ('{0}', {1},'{2}', '{3}', '{4}')", new string[] { Nombre, Edad, Cuenta, Contraseña, Estado_civil }), conexion);
            int filas_Afectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filas_Afectadas>0)
                return true;
            else
                return false;
        }

        public bool Eliminar(string ID_Cliente)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Delete from Clientes where ID_Cliente = {0}", ID_Cliente), conexion);
            int filas_Afectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filas_Afectadas > 0)
                return true;
            else
                return false;
        }

        public bool Actualizar(string ID_Cliente, string Nombre, string Edad, string Cuenta, string Contraseña, string Estado_civil)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("update Clientes set Nombre = '{0}', Edad = {1}, Cuenta = '{2}', Contraseña = '{3}', Estado_civil = '{4}' where ID_Cliente = {5}", new string[] { Nombre, Edad, Cuenta, Contraseña, Estado_civil, ID_Cliente }), conexion);
            int filas_Afectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filas_Afectadas > 0)
                return true;
            else
                return false;
        }
    }
}
