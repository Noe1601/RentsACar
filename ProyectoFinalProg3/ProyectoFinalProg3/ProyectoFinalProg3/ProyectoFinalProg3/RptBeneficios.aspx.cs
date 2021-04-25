using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalProg3
{
    public partial class RptBeneficios : System.Web.UI.Page
    {
        Datos data = new Datos();
        protected void Page_Load(object sender, EventArgs e)
        {

            GridView1.DataSource = data.Beneficios();
            GridView1.DataBind();
        }
    }
}