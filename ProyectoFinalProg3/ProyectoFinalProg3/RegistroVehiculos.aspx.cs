using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalProg3
{
    public partial class RegistroVehiculos : System.Web.UI.Page
    {
        string marca;
        string modelo;
        int anio;
        string color;
        int precio;
        string tipo;
        int capacidad;
        int pasajeros;
        string matricula;
        string seguro;
        string foto;
        string latitud;
        string longitud;

        Datos data = new Datos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Insert(0, new ListItem("[Seleccionar]"));
                DropDownList1.Items.Insert(0, new ListItem("Carro"));
                DropDownList1.Items.Insert(0, new ListItem("Jeepeta"));
                DropDownList1.Items.Insert(0, new ListItem("Camioneta"));
                DropDownList1.Items.Insert(0, new ListItem("Nave espacial"));
                DropDownList1.Items.Insert(0, new ListItem("Motor"));
            }

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
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            DropDownList1.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "" &&
                    TextBox5.Text != "" && TextBox6.Text != "" && TextBox7.Text != "" && TextBox8.Text != "" &&
                    TextBox9.Text != "" && TextBox10.Text != "" && TextBox11.Text != "" && TextBox12.Text != "" &&
                      DropDownList1.Text != "")
                {
                    marca = TextBox1.Text;
                    modelo = TextBox2.Text;
                    anio = int.Parse(TextBox3.Text);
                    color = TextBox4.Text;
                    precio = int.Parse(TextBox5.Text);
                    tipo = DropDownList1.Text;
                    capacidad = int.Parse(TextBox6.Text);
                    pasajeros = int.Parse(TextBox7.Text);
                    matricula = TextBox8.Text;
                    seguro = TextBox9.Text;
                    foto = TextBox10.Text;
                    latitud = TextBox11.Text;
                    longitud = TextBox12.Text;

                    data.GuardarVehiculos(marca,modelo,anio,color,precio,tipo,capacidad,pasajeros,
                        matricula,seguro,foto,latitud,longitud);
                    Clear();
                    ClientScript.RegisterStartupScript(this.GetType(),"random", "showAlert()",true);
                    Label12.Visible = true;
                    Label13.Visible = false;
                }
                else
                {
                    Console.WriteLine("ERROR");
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