using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinalProg3
{
    public class Datos
    {
        //MySqlConnection conexion = new MySqlConnection("server=freedb.tech; database=freedbtech_ProyectoFinalProg; Uid=freedbtech_NoeMedina; pwd=noemedina");
        //MySqlCommand comando;

        SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-QJ659VTB\\SQLEXPRESS01;Initial Catalog=PROG3FINAL;Integrated Security=True");
        SqlCommand comando;

        public void Loguearme(string correo, string cedula)
        {
            conexion.Open();
            string sql = $"SELECT * FROM USUARIOS WHERE USERNAME = '{correo}' AND PASS = '{cedula}' ";
            comando = new SqlCommand(sql, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        // INSERTS
        public void GuardarVehiculos(string marca, string modelo, int anio, string color, int precio,
            string tipo, int capacidad, int pasajeros, string matricula, string seguro, string foto, string latitud,
            string longitud)
        {
            conexion.Open();
            string sql = $"INSERT INTO VEHICULOS VALUES('{marca}','{modelo}',{anio},'{color}',{precio},'{tipo}',{capacidad},{pasajeros},'{matricula}','{seguro}','{foto}','{latitud}','{longitud}','NO')";
            comando = new SqlCommand(sql, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }


        public void GuardarClientes(string cedula, string nombre, string correo,
            string licencia, string nacionalidad, string sangre, string foto, string fotoLicencia)
        {
            conexion.Open();
            string sql = $"INSERT INTO CLIENTES VALUES('{cedula}','{nombre}','{correo}','{licencia}','{nacionalidad}','{sangre}','{foto}','{fotoLicencia}')";
            comando = new SqlCommand(sql, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void GuardarReservas(string vehiculo, string cliente, string fecha_inicio, string fecha_fin)
        {
            conexion.Open();
            string sql = $"INSERT INTO RESERVAS VALUES('{vehiculo}','{cliente}','{fecha_inicio}','{fecha_fin}',0)";
            comando = new SqlCommand(sql, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }


        // UPDATES

        public void ActualizarVehiculo(int id, string marca, string modelo, int anio, string color, int precio,
            string tipo, int capacidad, int pasajeros, string matricula, string seguro, string foto, string latitud,
            string longitud)
        {
            conexion.Open();
            string sql = $"UPDATE VEHICULOS SET MARCA = '{marca}',MODELO = '{modelo}', ANIO = {anio}, COLOR = '{color}',PRECIO_DIA = {precio}, TIPO = '{tipo}', CAPACIDAD_CARGA = {capacidad},PASAJEROS = {pasajeros}, MATRICULA = '{matricula}',NO_SEGURO = '{seguro}',FOTO = '{foto}',LATITUD = '{latitud}', LONGITUD = '{longitud}' WHERE ID = {id}";
            comando = new SqlCommand(sql, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void ActualizarCliente(int id,string cedula, string nombre, string correo,
            string licencia, string nacionalidad, string sangre, string foto, string fotoLicencia)
        {
            conexion.Open();
            string sql = $"UPDATE CLIENTES SET CEDULA = '{cedula}',NOMBRE = '{nombre}'," +
                $"CORREO = '{correo}',LICENCIA = '{licencia}', NACIONALIDAD = '{nacionalidad}'," +
                $"TIPO_SANGRE = '{sangre}', FOTO = '{foto}',FOTO_LICENCIA = '{fotoLicencia}' WHERE ID = {id}";
            comando = new SqlCommand(sql, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void RealizarPago(int id, int monto)
        {
            conexion.Open();
            string sql = $"UPDATE RESERVAS SET MONTO = MONTO - {monto} WHERE ID = {id}";
            comando = new SqlCommand(sql, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        // Cargar dropdowlist


        public DataTable CargarVehiculo()
        {
            conexion.Open();
            string consulta = "SELECT * FROM VEHICULOS";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

        public DataTable CargarCliente()
        {
            conexion.Open();
            string consulta = "SELECT * FROM CLIENTES";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

        // REPORTES
        public DataTable ListaVehiculos()
        {
            conexion.Open();
            string consulta = "SELECT * FROM VEHICULOS";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

        public DataTable ListaClientes()
        {
            conexion.Open();
            string consulta = "SELECT * FROM CLIENTES";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

        public DataTable Beneficios()
        {
            conexion.Open();
            string consulta = "SELECT V.MARCA AS 'MARCA',V.MODELO AS 'MODELO',V.COLOR AS 'COLOR' , COUNT(*) AS 'CANTIDAD', R.MONTO AS 'MONTO' FROM VEHICULOS V JOIN RESERVASBACKUP R ON(V.MODELO = R.VEHICULO) GROUP BY R.VEHICULO,V.MARCA,V.COLOR,R.MONTO,V.MODELO HAVING COUNT(*) >= 1";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

        public DataTable Deudas()
        {
            conexion.Open();
            string consulta = "SELECT C.CEDULA AS 'CEDULA',C.NOMBRE AS 'NOMBRE',R.MONTO AS 'MONTO' FROM CLIENTES C JOIN RESERVAS R ON (R.CLIENTE = C.NOMBRE) WHERE R.MONTO > 0";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

        public DataTable BuscarPorFecha(string fechainicial,string fechafinal)
        {
            conexion.Open();
            //string consulta = $"SELECT V.MARCA AS 'MARCA',V.MODELO AS 'MODELO',V.ANIO AS 'ANIO',V.COLOR AS 'COLOR',V.PRECIO_DIA AS 'PRECIO',V.PASAJEROS AS 'PASAJEROS',V.CAPACIDAD_CARGA AS 'CAPACIDAD',V.MATRICULA AS 'MATRICULA',V.NO_SEGURO AS 'SEGURO',V.FOTO AS 'FOTO',R.FECHA_INICIO AS 'FECHAINICIO',R.FECHA_FIN AS 'FECHAFIN' FROM VEHICULOS V JOIN RESERVAS R ON (V.MODELO = R.VEHICULO) WHERE R.FECHA_INICIO NOT IN('{fechainicial}') AND R.FECHA_FIN NOT IN('{fechafinal}')";
            //string consulta = $"SELECT * FROM VEHICULOS V JOIN RESERVAS R ON (V.MODELO = R.VEHICULO) WHERE R.FECHA_INICIO >= '{fechainicial}' OR R.FECHA_FIN <= '{fechafinal}'";
            string consulta = $"SELECT * FROM VEHICULOS V JOIN RESERVAS R ON (V.MODELO = R.VEHICULO) WHERE R.FECHA_INICIO NOT BETWEEN '{fechainicial}' AND '{fechafinal}' AND R.FECHA_FIN NOT BETWEEN '{fechainicial}' AND '{fechafinal}'";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

        /* VALIDAR DISPONIBLIDAD VEHICULO */

        public void Disponibilidad(string vehiculo, string fecahinicial, string fechafinal)
        {
            conexion.Open();
            //string sql = $"SELECT * FROM RESERVAS R WHERE R.VEHICULO = '{vehiculo}' AND ('{fecahinicial}' BETWEEN R.FECHA_INICIO AND R.FECHA_FIN OR '{fechafinal}' BETWEEN R.FECHA_INICIO AND R.FECHA_FIN)";
            //string sql = $"SELECT CASE VEHICULO WHEN '{vehiculo}' THEN 1 ELSE 0 END AS Existe FROM RESERVAS R WHERE R.VEHICULO = 'D-MAX' AND('{fecahinicial}' BETWEEN R.FECHA_INICIO AND R.FECHA_FIN OR '{fechafinal}' BETWEEN R.FECHA_INICIO AND R.FECHA_FIN)";
            string sql = $"SELECT * FROM RESERVAS WHERE VEHICULO = {vehiculo} AND FECHA_INICIO = {fecahinicial} AND FECHA_FIN = {fechafinal}";
            comando = new SqlCommand(sql, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

    }

   
}