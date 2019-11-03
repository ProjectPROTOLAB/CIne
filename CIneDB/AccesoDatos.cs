using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace CIneDB
{
    class AccesoDatos
    {
         
        OleDbConnection conexion;
        OleDbCommand comando;
        OleDbDataReader lector;
        DataTable tabla;
        string cadenaConexion;

        public OleDbDataReader pLector
        {
            set { lector = value; }
            get { return lector; }
        }


        public AccesoDatos(string cadenaConex)
        {
            conexion = new OleDbConnection();
            comando = new OleDbCommand();
            lector = null;
            tabla = new DataTable();
            cadenaConexion = cadenaConex;

        }
        public void conectar()
        {
            conexion.ConnectionString = cadenaConexion;
            this.conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
        public void desconectar()
        {
            conexion.Close();

        }

        public DataTable consultarTabla(string nombreTabla)
        {
            tabla = new DataTable();
            conectar();
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            desconectar();
            return tabla;

        }
        public DataTable consultar(string SQL)
        {
            tabla = new DataTable();
            conectar();
            comando.CommandText = SQL;
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }

        public void leerTabla(string nombreTabla)
        {
            conectar();
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            lector = comando.ExecuteReader();
        }

        public void actualizar(string consultaSQL)
        {

            conectar();
            comando.CommandText = consultaSQL;
            comando.ExecuteNonQuery();
            desconectar();
        }


    }
}
