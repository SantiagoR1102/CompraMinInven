using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Modelos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Conexion
{
    public class DBProveedores:ConexDB
    {

        //Guardar--------------------------------------------------------------
        public bool Guardar(int id, string NombreProveedor, int Nit, string Ciudad, int Telefono, string Correo)
        {
            string query = id > 0 ?
                "UPDATE Proveedores SET NombreProveedor=@NombreProveedor, Nit=@Nit, Ciudad=@Ciudad, Telefono=@Telefono, Correo=@Correo WHERE Id=@Id" :
                "INSERT INTO Proveedores (NombreProveedor, Nit, Ciudad, Telefono, Correo) VALUES (@NombreProveedor, @Nit, @Ciudad, @Telefono, @Correo)";

            bool rs = false;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@NombreProveedor", NombreProveedor),
                    new SqlParameter("@Nit", Nit),
                    new SqlParameter("@Ciudad", Ciudad),
                    new SqlParameter("@Telefono", Telefono),
                    new SqlParameter("@Correo", Correo)
                };

                if (id > 0)
                {
                    parameters.Add(new SqlParameter("@Id", id));
                }

                SqlCommand sqlCommand = COMANDO(query, parameters);
                rs = EJECUTAR_COMANDO(sqlCommand);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CerrarConexion();
            }
            return rs;
        }


        //Buscar------------------------------------
        public objProveedores Buscar(string Nit)
        {
            objProveedores rs = null;

            try
            {
                string query = "SELECT A.Nit, A.Nombre, A.Ciudad, A.Telefono, A.Correo FROM Proveedores A WHERE A.Nit = " + Nit;

                sqlCommand = COMANDO(query, null);
                dataTable = DATATABLE(sqlCommand);
                if (dataTable != null || dataTable.Rows.Count > 0)
                {

                    rs = new objProveedores()
                    {
                        Nombre = dataTable.Rows[0].Field<string>("Nombre"),
                        Ciudad = dataTable.Rows[0].Field<string>("Ciudad"),
                        Telefono = dataTable.Rows[0].Field<int>("Telefono"),
                        Correo = dataTable.Rows[0].Field<string>("Correo")

                    };
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CerrarConexion();
            }
            return rs;
        }

        /*ELIMINAR DATOS A LA BASE DE DATOS------------------------------------------------------------*/

        public bool eliminarDatos(int id)
        {
            bool rs = false;
            try
            {
                sqlCommand = COMANDO("DELETE FROM Proveedores WHERE Id=" + id, null);
                rs = Convert.ToBoolean(EJECUTAR_COMANDO(sqlCommand));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CerrarConexion();
            }
            return rs;
        }

        //Listar----------------------------------------------------------
        public List<Modelos.objProveedores> Listar()
        {
            List<Modelos.objProveedores> r = new List<Modelos.objProveedores>();
            try
            {
                string query = @"SELECT p.Id, p.Nombre AS Proveedores, p.Nit,
                                 p.Ciudad,
                                 FROM Proveedores p ";

                SqlDataReader dataReader = DATAREADER(query, null);
                while (dataReader.Read())
                {
                    r.Add(new Modelos.objProveedores()
                    {
                        id = dataReader.GetInt32(0),
                        Nombre = dataReader.GetString(1),
                        Nit = dataReader.GetInt32(2),
                        Ciudad = dataReader.GetString(3),
                        Telefono = dataReader.GetInt32(4),
                        Correo = dataReader.GetString(5)
                    });
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CerrarConexion();
            }
            return r;
        }
    }
}
