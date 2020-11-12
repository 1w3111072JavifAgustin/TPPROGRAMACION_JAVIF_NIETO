using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_final_final
{
    class Datos
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;
        DataTable tabla;
        string cadenaConexion;

        public string pCadenaConexion { get => cadenaConexion; set => cadenaConexion = value; }
        public SqlDataReader pLector { get => lector; set => lector = value; }

        public Datos()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            tabla = new DataTable();
            lector = null;
            cadenaConexion = "";
        }
        public Datos(string cadenaConexion)
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            tabla = new DataTable();
            lector = null;
            this.cadenaConexion = cadenaConexion;
        }

        public void conectar()
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;

        }
        public void desconectar()
        {
            conexion.Close();
            conexion.Dispose();
        }
        public DataTable consultarTabla(string nombreTabla)
        {
            this.tabla = new DataTable();
            conectar();
            this.comando.CommandText = "Select * From " + nombreTabla;
            this.tabla.Load(comando.ExecuteReader());
            this.desconectar();
            return tabla;

        }
        public void leerTabla(string nombreTabla)
        {
            this.conectar();
            this.comando.CommandText = "select * from " + nombreTabla;
            this.lector = this.comando.ExecuteReader();
        }

        public DataTable consultar(string sql)
        {
            DataTable dt = new DataTable();
            conectar();
            comando.CommandText = sql;
            dt.Load(comando.ExecuteReader());
            desconectar();
            return dt;
        }
        public void actualizar(string sql)
        {
            conectar();
            comando.CommandText = sql;
            comando.ExecuteNonQuery();
            desconectar();

        }
    }
}
