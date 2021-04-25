using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalProg3
{
    public partial class EditarVehiculos : System.Web.UI.Page
    {

        int id;
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
            TextBox13.Text = "";
        }


        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-QJ659VTB\\SQLEXPRESS01;Initial Catalog=PROG3FINAL;Integrated Security=True");
                SqlCommand comando;

                int id = int.Parse(TextBox13.Text);
                conexion.Open();
                string sql = $"SELECT * FROM VEHICULOS WHERE ID = {id}";
                comando = new SqlCommand(sql, conexion);
                SqlDataReader r = comando.ExecuteReader();
                while (r.Read())
                {
                    TextBox1.Text = r.GetValue(1).ToString();
                    TextBox2.Text = r.GetValue(2).ToString();
                    TextBox3.Text = r.GetValue(3).ToString();
                    TextBox4.Text = r.GetValue(4).ToString();
                    DropDownList1.SelectedValue = r.GetValue(6).ToString();
                    TextBox5.Text = r.GetValue(5).ToString();
                    TextBox6.Text = r.GetValue(7).ToString();
                    TextBox7.Text = r.GetValue(8).ToString();
                    TextBox8.Text = r.GetValue(9).ToString();
                    TextBox9.Text = r.GetValue(10).ToString();
                    TextBox10.Text = r.GetValue(11).ToString();
                    TextBox11.Text = r.GetValue(12).ToString();
                    TextBox12.Text = r.GetValue(13).ToString();
                }
                conexion.Close();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

            try
            {
                if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "" &&
                    TextBox5.Text != "" && TextBox6.Text != "" && TextBox7.Text != "" && TextBox8.Text != "" &&
                    TextBox9.Text != "" && TextBox10.Text != "" && TextBox11.Text != "" && TextBox12.Text != "" &&
                      DropDownList1.Text != "" && TextBox13.Text != "")
                {
                    id = int.Parse(TextBox13.Text);
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

                    data.ActualizarVehiculo(id, marca, modelo, anio, color, precio, tipo, capacidad, pasajeros,
                        matricula, seguro, foto, latitud, longitud);
                    Clear();
                }
                else
                {
                    Console.WriteLine("ERROR");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}