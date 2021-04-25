using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

            Button1.Enabled = false;
            Label5.Visible = false;
            Label6.Visible = false;
            Label7.Visible = false;
            Label8.Visible = false;
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

        public void Clear2()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
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
                    Label7.Visible = true;
                    Label5.Visible = false;
                    Label6.Visible = false;
                    Label8.Visible = false;
                }
                else
                {

                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Label7.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label8.Visible = true;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-QJ659VTB\\SQLEXPRESS01;Initial Catalog=PROG3FINAL;Integrated Security=True");
                SqlCommand comando;
                DataSet dsVehiculo = new DataSet();
                SqlDataAdapter dsVehiculo2 = new SqlDataAdapter();

                vehiculo = DropDownList1.Text;
                fechainicio = TextBox1.Text;
                fechafin = TextBox2.Text;

                //dsVehiculo2.SelectCommand.Connection = conexion;
                //dsVehiculo2.SelectCommand.CommandType = CommandType.Text;
                string sql = $"SELECT * FROM RESERVAS WHERE VEHICULO = '{vehiculo}' AND FECHA_INICIO = '{fechainicio}' AND FECHA_FIN = '{fechafin}'";
                comando = new SqlCommand(sql, conexion);
                dsVehiculo2.SelectCommand = comando;
                conexion.Open();
                dsVehiculo2.Fill(dsVehiculo, "RESERVAS");
                conexion.Close();

                if( dsVehiculo.Tables["RESERVAS"].Rows.Count > 0)
                {
                    Clear2();
                    Button1.Enabled = false;
                    Label6.Visible = true;
                    Label5.Visible = false;
                    Label7.Visible = false;
                    Label8.Visible = false;
                }
                else
                {
                    Button1.Enabled = true;
                    Label5.Visible = true;
                    Label6.Visible = false;
                    Label7.Visible = false;
                    Label8.Visible = false;
                }
              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}