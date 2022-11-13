using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Reflection.Emit;
using System.Text;

namespace tarea4
{
    public partial class paciente : System.Web.UI.Page
    {

        public SqlConnection conexion;
        public string constr = ConfigurationManager.ConnectionStrings["HOSPITALConnectionString"].ConnectionString;


        protected void Button3_Click(object sender, EventArgs e)
        {
            
            conexion = new SqlConnection(constr);
            conexion.Open();

            
            string sql = "Select * from Paciente where nombre = @nombre";
            SqlCommand cmd = new SqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@nombre",Tnombre.Text);

            SqlDataReader reader = cmd.ExecuteReader();
           
            GridView2.DataSource = reader;  
           GridView2.DataBind();   
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double porcentaje13 = 0;
            double porcentaje1330 = 0;
            double porcentaje30 = 0;
            int contador = 0;
            int con1 = 0;
            int con2 = 0;
            int con3 = 0;
            conexion = new SqlConnection(constr);
            conexion.Open();


            string sql = "Select * from Paciente";
            SqlCommand cmd = new SqlCommand(sql, conexion);
            //cmd.Parameters.AddWithValue("@nombre", Tnombre.Text);

            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                if (int.Parse(reader["edad"].ToString()) < 13)
                    con1++;
                if(int.Parse(reader["edad"].ToString()) >= 13 && int.Parse(reader["edad"].ToString()) < 30)
                    con2++;
                if(int.Parse(reader["edad"].ToString()) > 30)
                    con3++;
                contador++; 

            }
            porcentaje13 = (con1 * 100) / contador;
            porcentaje1330 = (con2 * 100) / contador;
            porcentaje30 = (con3 * 100) / contador;

            Label1.Visible = true;
            Label1.Text = "Menores de 13: ";
            Label4.Visible = true;
            Label4.Text = porcentaje13.ToString()+"%";

            Label2.Visible = true;
            Label2.Text = "Entre 13 y 30: ";
            Label5.Visible = true;
            Label5.Text = porcentaje1330.ToString()+"%";

            Label3.Visible = true;
            Label3.Text = "Mayores a 30: ";
            Label6.Visible = true;
            Label6.Text = porcentaje30.ToString() + "%";

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double porcentajeM = 0;
            double porcentajeF = 0;
            
            int contador = 0;
            int con1 = 0;
            int con2 = 0;
            
            conexion = new SqlConnection(constr);
            conexion.Open();


            string sql = "Select * from Paciente";
            SqlCommand cmd = new SqlCommand(sql, conexion);
            //cmd.Parameters.AddWithValue("@nombre", Tnombre.Text);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader["genero"].ToString().Equals("M"))
                    con1++;
                if (reader["genero"].ToString().Equals("F"))
                    con2++;
                
                contador++;

            }

            porcentajeF = (con2*100)/contador;
            porcentajeM = (con1 * 100) / contador;

            Label3.Visible = false;
            Label6.Visible = false;

            Label1.Visible = true;
            Label1.Text = "Femenino: ";
            Label4.Visible = true;
            Label4.Text = porcentajeF.ToString() + "%";

            Label2.Visible = true;
            Label2.Text = "Masculino: ";
            Label5.Visible = true;
            Label5.Text = porcentajeM.ToString() + "%";


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            double porcentajeS = 0;
            double porcentajeN = 0;

            int contador = 0;
            int con1 = 0;
            int con2 = 0;

            conexion = new SqlConnection(constr);
            conexion.Open();


            string sql = "Select * from Paciente";
            SqlCommand cmd = new SqlCommand(sql, conexion);
            //cmd.Parameters.AddWithValue("@nombre", Tnombre.Text);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //Label3.Visible = true;
                //Label3.Text = reader["seguro"].ToString();
                if (reader["seguro"].ToString().Equals("True"))
                { con1++;
                    


                }
                if (reader["seguro"].ToString().Equals("False"))
                {
                    con2++;
                   
                }
                
                contador++;

            }

            porcentajeS = (con1 * 100) / contador;
            porcentajeN = (con2 * 100) / contador;

            Label3.Visible = false;
            Label6.Visible = false;

            Label1.Visible = true;
            Label1.Text = "Tiene seguro: ";
            Label4.Visible = true;
            Label4.Text = porcentajeS.ToString() + "%";

            Label2.Visible = true;
            Label2.Text = "No tiene seguro: ";
            Label5.Visible = true;
            Label5.Text = porcentajeN.ToString() + "%";
        }
    }
}