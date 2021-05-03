using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace practicaCesar
{
    public partial class ventadetallada : System.Web.UI.Page
    {

        private string rutabd = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=EjercicioParcial;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
            string consulta = "select idArticulo_ar,nombre_ar from Articulo";
            SqlConnection cn = new SqlConnection(rutabd);

            cn.Open();

            SqlCommand cmd = new SqlCommand(consulta, cn);

            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                ddarticulos.Items.Add(new ListItem((string)dr["nombre_ar"],Convert.ToString(dr["idArticulo_ar"])));
            }
            cn.Close();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           decimal total = Convert.ToDecimal(tbcantidad.Text) * Convert.ToDecimal(tbprecio.Text);

            tbtotal.Text = Convert.ToString(total);
            

        }

        protected void ddarticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            articulos a = new articulos();

             string pre=a.PrecioArticulo(ddarticulos.SelectedValue);
             tbprecio.Text =pre;


        }
    }
}