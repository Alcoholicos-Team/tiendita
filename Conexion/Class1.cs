using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Conexion
{
    public class Utilidades
    {
        //Cadena de conexión
        SqlConnection conex = new SqlConnection("Data Source=DESKTOP-TORUÑO;Initial Catalog=ProyectoTiendita;Integrated Security=true");
        //guarda varias tablas y sirve para mostrar datos
        DataSet DS;

        //Metodo dataset para la conexión y verificación de datos
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
    }
}
