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
                Cargar c = new Cargar();

                c.Cargarr(ddtipoventa, "idtipoventa_tv", "decripcion_tv", " tiposdeventas ");
                c.Cargarr(ddhora, "idhora_hr", "horarios_hr", " horarios ");
                c.Cargarr(ddformaPago, "idformapago_fp", "descripcion_fp", " formaPago ");
                c.Cargarr(ddzona, "idzona_zo", "descripcion_zo", " zonas ");
                

            }
        }


        protected void next_Click(object sender, EventArgs e)
        {

            string campos = "idventa_ve, idcliente_ve, entrega_ve, idtipoventa_ve, idhorario_ve, idformapago_ve, idzona_ve";
            string valore=" '"+tbidventa.Text+"','"+idcliente.Text+"','"+tbentrega.Text+"','"+ddtipoventa.SelectedValue+"','"+ddhora.SelectedValue+"','"+ddformaPago.SelectedValue+"','"+ddzona.SelectedValue+"'";

            Ventas v = new Ventas();

            if(v.insert(campos, valore))
            {
                Label1.Text = "Se agrego la venta";
            }
         

        }
    }
}