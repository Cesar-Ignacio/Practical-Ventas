using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;

namespace practicaCesar
{
    public class Cargar
    {
        public string rutaBD = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=EjercicioParcial;Integrated Security=True";


        public void Cargarr(DropDownList ddls, string campo1, string campo2, string DataBase)
        {
            string consulta = "select " + campo1 + "," + campo2 + " from" + DataBase;

            SqlConnection cn = new SqlConnection(rutaBD);
            cn.Open();

            SqlCommand cmd = new SqlCommand(consulta, cn);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ddls.Items.Add(new ListItem((string)dr[campo2], "" + dr[campo1]));
            }

            cn.Close();
        }

    }
}