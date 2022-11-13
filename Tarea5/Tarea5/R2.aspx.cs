using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea5
{
    public partial class R2 : System.Web.UI.Page
    {
        public string cedula;
        public string r1;
        protected void Page_Load(object sender, EventArgs e)
        {
            cedula = Request.QueryString["cedula"];
            r1 = Request.QueryString["r1"];
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            var lista = new List<string>();
            var interString = string.Join(",", lista);

            Response.Redirect("R3.aspx?cedula=" + cedula + "&r1=" + r1 + "&r2=" + DropDownList1.SelectedValue
                +"&lista=" + HttpUtility.UrlEncode(interString));
        }
    }
}