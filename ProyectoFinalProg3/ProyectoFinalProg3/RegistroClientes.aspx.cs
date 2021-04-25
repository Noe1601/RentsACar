using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalProg3
{
    public partial class RegistroClientes : System.Web.UI.Page
    {

        Datos data = new Datos();

        string cedula;
        string nombre;
        string correo;
        string licencia;
        string nacionalidad;
        string sangre;
        string fotopersonal;
        string fotolicencia;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label12.Visible = false;
            Label13.Visible = false;
        }

        public void Clear()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" &&
                    TextBox4.Text != "" && TextBox5.Text != "" && TextBox6.Text != "" && TextBox7.Text != ""
                    && TextBox8.Text != "")
                {
                    cedula = TextBox1.Text;
                    nombre = TextBox2.Text;
                    correo = TextBox3.Text;
                    licencia = TextBox4.Text;
                    nacionalidad = TextBox5.Text;
                    sangre = TextBox6.Text;
                    fotopersonal = TextBox7.Text;
                    fotolicencia = TextBox8.Text;

                    data.GuardarClientes(cedula, nombre, correo, licencia, nacionalidad, sangre, fotopersonal,
                        fotolicencia);
                    Clear();
                    Label12.Visible = true;
                    Label13.Visible = false;
                }
                else
                {
                    Label12.Visible = false;
                    Label13.Visible = true;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Label12.Visible = false;
                Label13.Visible = true;
            }
        }
    }
}