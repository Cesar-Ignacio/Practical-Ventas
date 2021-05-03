using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace practicaCesar
{
    public class Ventas
    {

       public string rutaBD = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=EjercicioParcial;Integrated Security=True";


        public bool insert(string campos, string valore)
        {
            string consulta = "insert into Ventas(" + campos + ")values(" + valore + ")";

            SqlConnection cn = new SqlConnection(rutaBD);

            cn.Open();

            SqlCommand cmd = new SqlCommand(consulta, cn);

            int file = cmd.ExecuteNonQuery();

            cn.Close();


            return Convert.ToBoolean(file);
        }



    }
}