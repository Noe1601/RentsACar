using Microsoft.AspNet.FriendlyUrls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalProg3
{
    public partial class Login : System.Web.UI.Page
    {

        Datos data = new Datos();
        string correo;
        string cedula;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                correo = TextBox1.Text;
                cedula = TextBox2.Text;

                data.Loguearme(correo, cedula);
                Response.Redirect("https://localhost:44371/Principal");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}