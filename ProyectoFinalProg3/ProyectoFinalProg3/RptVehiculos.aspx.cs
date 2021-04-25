using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalProg3
{
    public partial class RptVehiculos : System.Web.UI.Page
    {
        string fechainicial;
        string fechafinasl;
        Datos data = new Datos();
        protected void Page_Load(object sender, EventArgs e)
        {

            //GridView1.DataSource = data.CargarVehiculo();
            //GridView1.DataBind();
        }

        public void Clear()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                fechainicial = TextBox1.Text;
                fechafinasl = TextBox2.Text;
                GridView1.DataSource = data.BuscarPorFecha(fechainicial, fechafinasl);
                GridView1.DataBind();
                Clear();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}