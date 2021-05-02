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
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string rutaBD = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=EjercicioParcial;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Cargar(ddtipoventa,"idtipoventa_tv", "decripcion_tv"," tiposdeventas ");
                Cargar(ddhora, "idhora_hr", "horarios_hr", " horarios ");
                Cargar(ddformaPago,"idformapago_fp","descripcion_fp"," formaPago ");
                Cargar(ddzona, "idzona_zo", "descripcion_zo", " zonas ");

            }
        }
        protected void Cargar(DropDownList ddls,string campo1,string campo2, string DataBase)
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

        protected void Button1_Click(object sender, EventArgs e)
        {

            string campos = "idventa_ve, idcliente_ve, entrega_ve, idtipoventa_ve, idhorario_ve, idformapago_ve, idzona_ve";
            string valore=" '"+tbidventa.Text+"','"+idcliente.Text+"','"+tbentrega.Text+"','"+ddtipoventa.SelectedValue+"','"+ddhora.SelectedValue+"','"+ddformaPago.SelectedValue+"','"+ddzona.SelectedValue+"'";
            
            string consulta = "insert into Ventas("+campos+")values("+valore+")";

            SqlConnection cn = new SqlConnection(rutaBD);

            cn.Open();

            SqlCommand cmd = new SqlCommand(consulta, cn);

            int file = cmd.ExecuteNonQuery();

            cn.Close();

        }
    }
}