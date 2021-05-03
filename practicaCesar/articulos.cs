using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace practicaCesar
{
    public class articulos
    {
         
        public string rutabd = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=EjercicioParcial;Integrated Security=True";

        public string PrecioArticulo(string idart)
        {
            string consult = "select  precio_ar from Articulo where idArticulo_ar=" + idart;

            SqlConnection cn = new SqlConnection(rutabd);

            cn.Open();

            SqlCommand cmd = new SqlCommand(consult, cn);

            SqlDataReader dr = cmd.ExecuteReader();


            dr.Read();

            string pre = Convert.ToString(dr["precio_ar"]);

            /*
            string pre="";
            while (dr.Read())
            {
              pre=Convert.ToString(dr["precio_ar"]);
            }
            */
            cn.Close();

            return pre;
        }


    }
}