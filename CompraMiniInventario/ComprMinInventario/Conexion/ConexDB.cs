using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Conexion
{
    class ConexDB
    {
        private SqlConnection conexion;
        private string connectionString;
        public SqlCommand sqlCommand;

        /*CONEXION A LA BASE DE DATOS------------------------------------------------------------*/
        public ConexBD()
        {
            connectionString = "SERVER=SISTEMAS-1; User Id=sa; Password=dolce; DataBase=ComprasMiniInventario";
            conexion = new SqlConnection(connectionString);
        }

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }
}
