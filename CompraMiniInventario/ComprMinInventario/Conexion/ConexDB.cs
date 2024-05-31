using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace Conexion
{
    public class ConexDB
    {
        private SqlConnection conexion;
        private string connectionString;
        public SqlCommand sqlCommand;
        public SqlDataReader dataReader;
        public DataTable dataTable;
        public SqlDataAdapter dataAdapter;

        /*CONEXION A LA BASE DE DATOS------------------------------------------------------------*/
        public ConexDB()
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


        /*CODIGO PARA EL INSERTAR, ELIMINAR, ACTUALIZAR ------------------------------------------------------------*/

        public SqlCommand COMANDO(string QUERY, List<SqlParameter> parameters)
        {
            sqlCommand = new SqlCommand()
            {
                Connection = conexion,
                CommandTimeout = 0,
                CommandType =
                CommandType.Text,
                CommandText = QUERY
            };
            sqlCommand.Parameters.Clear();
            if (parameters != null)
            {
                sqlCommand.Parameters.AddRange(parameters.ToArray());
            }
            AbrirConexion();
            return sqlCommand;
        }

        public bool EJECUTAR_COMANDO(SqlCommand command)
        {
            bool rs = Convert.ToBoolean(command.ExecuteNonQuery());
            return rs;
        }

        public SqlDataReader DATAREADER(string QUERY, List<SqlParameter> parameters)
        {
            try
            {
                sqlCommand = COMANDO(QUERY, parameters);
                IAsyncResult RS = sqlCommand.BeginExecuteReader(CommandBehavior.CloseConnection);
                while (!RS.IsCompleted)
                {
                    Thread.Sleep(100);
                }
                dataReader = sqlCommand.EndExecuteReader(RS);
            }
            catch (Exception e)
            {
                throw new InvalidCastException(e.ToString());
            }
            return dataReader;
        }

        public DataTable DATATABLE(SqlCommand command) { dataTable = new DataTable(); dataAdapter = new SqlDataAdapter(command); dataAdapter.Fill(dataTable); return dataTable; }
    }
}
