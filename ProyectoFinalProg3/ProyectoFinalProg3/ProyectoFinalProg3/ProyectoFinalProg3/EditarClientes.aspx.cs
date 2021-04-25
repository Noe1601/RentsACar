using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalProg3
{


    public partial class EditarClientes : System.Web.UI.Page
    {
        int id;
        string cedula;
        string nombre;
        string correo;
        string licencia;
        string nacionalidad;
        string sangre;
        string fotopersonal;
        string fotolicencia;

        Datos data = new Datos();
        protected void Page_Load(object sender, EventArgs e)
        {

       
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-QJ659VTB\\SQLEXPRESS01;Initial Catalog=PROG3FINAL;Integrated Security=True");
                SqlCommand comando;

                int id = int.Parse(TextBox9.Text);
                conexion.Open();
                string sql = $"SELECT * FROM CLIENTES WHERE ID = {id}";
                comando = new SqlCommand(sql, conexion);
                SqlDataReader r = comando.ExecuteReader();
                while (r.Read())
                {
                    TextBox1.Text = r.GetValue(1).ToString();
                    TextBox2.Text = r.GetValue(2).ToString();
                    TextBox3.Text = r.GetValue(3).ToString();
                    TextBox4.Text = r.GetValue(4).ToString();
                    TextBox5.Text = r.GetValue(5).ToString();
                    TextBox6.Text = r.GetValue(6).ToString();
                    TextBox7.Text = r.GetValue(7).ToString();
                    TextBox8.Text = r.GetValue(8).ToString();
                }
                conexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" &&
                    TextBox4.Text != "" && TextBox5.Text != "" && TextBox6.Text != "" && TextBox7.Text != ""
                    && TextBox8.Text != "")
                {
                    id = int.Parse(TextBox9.Text);
                    cedula = TextBox1.Text;
                    nombre = TextBox2.Text;
                    correo = TextBox3.Text;
                    licencia = TextBox4.Text;
                    nacionalidad = TextBox5.Text;
                    sangre = TextBox6.Text;
                    fotopersonal = TextBox7.Text;
                    fotolicencia = TextBox8.Text;

                    data.ActualizarCliente(id,cedula, nombre, correo, licencia, nacionalidad, sangre, fotopersonal,
                        fotolicencia);
                    Clear();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}