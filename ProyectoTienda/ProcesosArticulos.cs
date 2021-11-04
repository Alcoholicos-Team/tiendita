using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoTienda
{
    class ProcesosArticulos
    {
        SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-TORUÑO; Initial Catalog = ProyectoTiendita; Integrated Security = True");

        //guarda varias tablas y sirve para mostrar datos
        DataSet ds;

        public DataTable MostrarDatos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("Select * from Articulos", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "Tabla");
            conexion.Close();
            return ds.Tables["Tabla"];
        }

        public DataTable BuscarDatos(string NombreArt, string codigo_Articulo)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Select * from Articulos where NombreArt like '%{0}%' OR codigo_Articulo like '%{1}%'", NombreArt,codigo_Articulo), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "Tabla");
            conexion.Close();
            return ds.Tables["Tabla"];
        }

        public bool Insertar(string ID_Articulo, string NombreArt, string codigo_Articulo, string departamento, string PrecioArt)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Insert into Articulos values ('{0}', {1}, '{2}', {3})", new string[] {NombreArt, codigo_Articulo, departamento, PrecioArt }), conexion);
            int filas_Afectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filas_Afectadas > 0)
                return true;
            else
                return false;
        }

        public bool Eliminar(string ID_Articulo)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Delete from Articulos where ID_Articulo = {0}", ID_Articulo), conexion);
            int filas_Afectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filas_Afectadas > 0)
                return true;
            else
                return false;
        }

        public bool Actualizar(string ID_Articulo, string NombreArt, string codigo_Articulo, string departamento, string PrecioArt)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("update Articulos set NombreArt = '{0}', codigo_Articulo = {1}, departamento = '{2}', PrecioArt = {3} where ID_Articulo = {4}", new string[] { NombreArt, codigo_Articulo, departamento, PrecioArt, ID_Articulo }), conexion);
            int filas_Afectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filas_Afectadas > 0)
                return true;
            else
                return false;
        }
    }
}
