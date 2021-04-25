using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalProg3
{
    public partial class Cobros : System.Web.UI.Page
    {
        Datos data = new Datos();

        int id;
        int monto;
        protected void Page_Load(object sender, EventArgs e)
        {

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
                if(TextBox1.Text != "" && TextBox2.Text != "")
                {
                    id = int.Parse(TextBox1.Text);
                    monto = int.Parse(TextBox2.Text);

                    data.RealizarPago(id, monto);
                    Clear();
                }
                else
                {

                }

            }catch(Exception ex)
            {

            }
        }
    }
}