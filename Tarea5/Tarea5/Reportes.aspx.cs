using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;


namespace Tarea5
{
    public partial class Reportes : System.Web.UI.Page
    {
        public SqlConnection conexion;
        public string constr = ConfigurationManager.ConnectionStrings["EncuestasConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection(constr);
            conexion.Open();
            string sql2 = "select Personas.nombre, Personas.genero, Personas.fecha, Respuestas.r1, Respuestas.r2, Respuestas.r3 from Respuestas join Personas on Respuestas.cedula = Personas.cedula";
            SqlCommand cmd2 = new SqlCommand(sql2, conexion);
            //cmd2.Parameters.AddWithValue("@cedula", cedula);
            SqlDataReader lector2 = cmd2.ExecuteReader();
            GridView1.DataSource = lector2;
            GridView1.DataBind();
            conexion.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
    }
}