using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MiConexión
{
    public class UtilidadesSQL
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection conex = new SqlConnection("Data Source = DESKTOP-TORUÑO; Initial Catalog = ProyectoTiendita; Integrated Security = true");
            conex.Open();
            DataSet Ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter(cmd,conex);
            DA.Fill(Ds);
            conex.Close();
            return Ds;
        }
    }
}

