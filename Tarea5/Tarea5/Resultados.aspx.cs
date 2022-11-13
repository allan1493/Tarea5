using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea5
{
    public partial class Resultados : System.Web.UI.Page
    {
        public string cedula;
        public string r1;
        public string r2;
        public string r3;
        public SqlConnection conexion;
        public string constr = ConfigurationManager.ConnectionStrings["EncuestasConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection(constr);
            conexion.Open();
            
            cedula = Request.QueryString["cedula"];
            Label1.Text = cedula;
            r1 = Request.QueryString["r1"];
            r2 = Request.QueryString["r2"];
            r3 = Request.QueryString["r3"];
            string sql = "Insert into Respuestas values (@cedula, @r1,@r2,@r3)";
            SqlCommand cmd = new SqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@cedula", cedula);
            cmd.Parameters.AddWithValue("@r1", r1);
            cmd.Parameters.AddWithValue("@r2", r2);
            cmd.Parameters.AddWithValue("@r3", r3);


            SqlDataReader lector = cmd.ExecuteReader();
            conexion.Close();

            conexion.Open();
            string sql2 = "select * from Respuestas where cedula = @cedula";
            SqlCommand cmd2 = new SqlCommand(sql2 , conexion);
            cmd2.Parameters.AddWithValue("@cedula", cedula);
            SqlDataReader lector2 = cmd2.ExecuteReader();
            GridView1.DataSource = lector2;
            GridView1.DataBind();
            conexion.Close();

            conexion.Open();
            string sql3 = "select * from RespuestasPrueba";
            SqlCommand cmd3 = new SqlCommand(sql3, conexion);
            SqlDataReader lector3 = cmd3.ExecuteReader();
            GridView2.DataSource = lector3;
            GridView2.DataBind();

            //int rowind = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            double resultado = 0;
            int contador = 0;
            if (r1.Equals(GridView2.Rows[0].Cells[0].Text))
                contador++;
            if (r2.Equals(GridView2.Rows[0].Cells[1].Text))
                contador++;
            if (r3.Equals(GridView2.Rows[0].Cells[2].Text))
                contador++;

            resultado = (contador * 100) / 3;
            Label1.Text = resultado.ToString() +"%";
            conexion.Close();
        }

        protected void Menu_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
    }
}