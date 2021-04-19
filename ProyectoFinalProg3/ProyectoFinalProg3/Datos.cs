using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Compilation;

namespace ProyectoFinalProg3
{
    public class Datos
    {
        MySqlConnection conexion = new MySqlConnection("server=freedb.tech; database=freedbtech_ProyectoFinalProg; Uid=freedbtech_NoeMedina; pwd=noemedina");
        MySqlCommand comando;

        // INSERTS
        public void GuardarVehiculos(string marca,string modelo,int anio,string color,int precio,
            string tipo,int capacidad,int pasajeros,string matricula,string seguro,string foto,string latitud,
            string longitud)
        {
            conexion.Open();
            string sql = $"INSERT INTO VEHICULOS VALUES('{marca}','{modelo}',{anio},'{color}',{precio},'{tipo}',{capacidad},{pasajeros},'{matricula}','{seguro}','{foto}','{latitud}','{longitud}')";
            comando = new MySqlCommand(sql, conexion);
            conexion.Close();
        }


        public void GuardarClientes(string cedula,string nombre,string apellido,string correo,
            string licencia,string nacionalidad,string sangre,string foto,string fotoLicencia)
        {
            conexion.Open();
            string sql = $"INSERT INTO CLIENTES VALUES('{cedula}','{nombre}','{apellido}','{correo}','{licencia}','{nacionalidad}','{sangre}','{foto}','{fotoLicencia}')";
            comando = new MySqlCommand(sql, conexion);
            conexion.Close();
        }

        public void GuardarReservas(int vehiculo,int cliente,string fecha_inicio,string fecha_fin, int monto)
        {
            conexion.Open();
            string sql = $"INSERT INTO RESERVAS2 VALUES({vehiculo},{cliente},'{fecha_inicio}','{fecha_fin}',{monto})";
            comando = new MySqlCommand(sql, conexion);
            conexion.Close();
        }


        // UPDATES

        public void ActualizarVehiculo(int id,string marca, string modelo, int anio, string color, int precio,
            string tipo, int capacidad, int pasajeros, string matricula, string seguro, string foto, string latitud,
            string longitud)
        {
            conexion.Open();
            string sql = $"UPDATE VEHICULOS SET MARCA = '{marca}',MODELO = '{modelo}', ANIO = {anio}, COLOR = '{color}'," +
                $"PRECIO = {precio}, TIPO = '{tipo}', CAPACIDAD = {capacidad},PASAJEROS = {pasajeros}, MATRICULA = '{matricula}'" +
                $"NO_SEGURO = '{seguro}',FOTO = '{foto}',LATITUD = '{latitud}', LONGITUD = '{longitud}' WHERE ID = {id}";
            comando = new MySqlCommand(sql, conexion);
            conexion.Close();
        }

        public void ActualizarCliente(string cedula, string nombre, string apellido, string correo,
            string licencia, string nacionalidad, string sangre, string foto, string fotoLicencia)
        {
            conexion.Open();
            string sql = $"UPDATE CLIENTES SET CEDULA = '{cedula}',NOMBRE = '{nombre}', APELLIDO = '{apellido}'," +
                $"CORREO = '{correo}',LICENCIA = '{licencia}', NACIONALIDAD = '{nacionalidad}'," +
                $"SANGRE = '{sangre}', FOTO = '{foto}',FOTO_LICENCIA = '{fotoLicencia}' WHERE CEDULA = {cedula}";
            comando = new MySqlCommand(sql,conexion);
            conexion.Close();
        }

        public void RealizarPago(int id,int monto)
        {
            conexion.Open();
            string sql = $"UPDATE RESERVAS2 SET MONTO = MONTO - {monto} WHERE ID = {id}";
            comando = new MySqlCommand(sql, conexion);
            conexion.Close();
        }

        // Cargar dropdowlist


        public DataTable CargarVehiculo()
        {
            conexion.Open();
            string consulta = "SELECT * FROM VEHICULOS";
            comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

        public DataTable CargarCliente()
        {
            conexion.Open();
            string consulta = "SELECT * FROM CLIENTES";
            comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
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
            comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

        public DataTable ListaClientes()
        {
            conexion.Open();
            string consulta = "SELECT * FROM CLIENTES";
            comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }
    }

   
}