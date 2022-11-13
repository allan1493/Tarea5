using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Tarea5
{
    public partial class R1 : System.Web.UI.Page
    {
        public SqlConnection conexion;
        public string constr = ConfigurationManager.ConnectionStrings["EncuestasConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection(constr);
            conexion.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sql = "Insert into Personas values (@cedula, @nombre,@genero,@date)";
            SqlCommand cmd = new SqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@cedula", TCedula.Text);
            cmd.Parameters.AddWithValue("@nombre", TNombre.Text);
            cmd.Parameters.AddWithValue("@genero", DropDownList1.SelectedValue);
            cmd.Parameters.AddWithValue("@date", DateTime.Today);


            SqlDataReader lector = cmd.ExecuteReader();
            Label1.Visible = true;
            Label1.Text = "Ingreso Exitoso";

            Image1.Visible = true;
            DropDownList2.Visible = true;
            Button2.Visible = true;


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var lista = new List<string>();
            var interString = string.Join(",", lista);

            Response.Redirect("R2.aspx?cedula=" + this.TCedula.Text+"&r1="+this.DropDownList2.SelectedValue +
                "&lista=" +HttpUtility.UrlEncode(interString));
        }
    }
    
}