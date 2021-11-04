using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoTienda
{
    class Procesos
    {
        SqlConnection conex = new SqlConnection("Data Source=DESKTOP-TORUÑO;Initial Catalog=ProyectoTiendita;Integrated Security=true");
        //guarda varias tablas y sirve para mostrar datos
        DataSet DS;

        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection conex = new SqlConnection("Data Source=DESKTOP-TORUÑO;Initial Catalog=ProyectoTiendita;Integrated Security=true");
            conex.Open();
            DataSet Ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter(cmd, conex);
            DA.Fill(Ds);
            conex.Close();
            return Ds;
        }
        public DataTable MostrarDatos()
        {
            DataSet Ds = new DataSet();
            conex.Open();
            SqlCommand cmd = new SqlCommand("Select * from Usuarios", conex);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DS = new DataSet();
            ad.Fill(DS, "Tabla");
            conex.Close();
            return DS.Tables["Tabla"];
        }

        public DataTable BuscarDatos(string Numbre_Usuario, string Usuario, string Estado_Usuario)
        {
            conex.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Select * from Usuarios where Numbre_Usuario like '%{0}%' OR Usuario like '%{1}%' OR Etado_Usuario like '%{2}%'", Numbre_Usuario, Usuario,Estado_Usuario), conex);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DS = new DataSet();
            ad.Fill(DS, "Tabla");
            conex.Close();
            return DS.Tables["Tabla"];
        }

        public bool Insertar(string ID_Uusarios, string Numbre_Usuario, string Usuario, string Contraseña, string Fecha_Nacimiento, string Edad, string Etado_Usuario)
        {
            conex.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Insert into Usuarios values ('{0}', '{1}','{2}', '{3}', {4},'{5}')", new string[] { Numbre_Usuario, Usuario, Contraseña, Fecha_Nacimiento, Edad, Etado_Usuario }), conex);
            int filas_Afectadas = cmd.ExecuteNonQuery();
            conex.Close();
            if (filas_Afectadas > 0)
                return true;
            else
                return false;
        }

        public bool Eliminar(string ID_Uusarios)
        {
            conex.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Delete from Usuarios where ID_Uusarios = '{0}'", ID_Uusarios), conex);
            int filas_Afectadas = cmd.ExecuteNonQuery();
            conex.Close();
            if (filas_Afectadas > 0)
                return true;
            else
                return false;
        }

        public bool Actualizar(string ID_Uusarios, string Numbre_Usuario, string Usuario, string Contraseña, string Fecha_Nacimiento, string Edad, string Etado_Usuario)
        {
            conex.Open();
            SqlCommand cmd = new SqlCommand(string.Format("update Usuarios set Numbre_Usuario = '{0}', Usuario = '{1}', Contraseña = '{2}', Fecha_Nacimiento = '{3}', Edad = {4}, Etado_Usuario = '{5}' where ID_Uusarios = {6}", new string[] { Numbre_Usuario, Usuario, Contraseña, Fecha_Nacimiento, Edad, Etado_Usuario, ID_Uusarios }), conex);
            int filas_Afectadas = cmd.ExecuteNonQuery();
            conex.Close();
            if (filas_Afectadas > 0)
                return true;
            else
                return false;
        }

    }
}
