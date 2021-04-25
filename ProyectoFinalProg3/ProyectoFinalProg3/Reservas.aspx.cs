using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalProg3
{
    public partial class Reservas : System.Web.UI.Page
    {

        Datos data = new Datos();

        string vehiculo;
        string cliente;
        string fechainicio;
        string fechafin;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Llenar();
            }
        }

        public void Llenar()
        {
            // Provincia
            DropDownList2.DataSource = data.ListaClientes();
            DropDownList2.DataTextField = "NOMBRE";
            DropDownList2.DataValueField = "NOMBRE";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, new ListItem("[Seleccionar]"));

            DropDownList1.DataSource = data.ListaVehiculos();
            DropDownList1.DataTextField = "MODELO";
            DropDownList1.DataValueField = "MODELO";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("[Seleccionar]"));
        }

        public void Clear()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            DropDownList1.Text = "";
            DropDownList2.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(TextBox1.Text != "" && TextBox2.Text != "" && 
                    DropDownList1.Text != "" && DropDownList2.Text != "")
                {
                    vehiculo = DropDownList1.Text;
                    cliente = DropDownList2.Text;
                    fechainicio = TextBox1.Text;
                    fechafin = TextBox2.Text;

                    data.GuardarReservas(vehiculo, cliente, fechainicio, fechafin);
                    Clear();
                }
                else
                {

                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}