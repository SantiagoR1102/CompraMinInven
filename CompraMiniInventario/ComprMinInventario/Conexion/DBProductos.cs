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
    public class DBProductos : ConexDB
    {
        public bool Guardar(int id, string NombreProducto, string Codigo, int Costo, string Garantia, string Cantidad)
        {
            string query = id > 0 ?
                "UPDATE Productos SET NombreProducto=@NombreProducto, Codigo=@Codigo, Costo=@Costo, Garantia=@Garantia, Cantidad=@Cantidad WHERE Id=@Id" :
                "INSERT INTO Productos (NombreProducto, Codigo, Costo, Garantia, Cantidad) VALUES (@NombreProducto, @Codigo, @Costo, @Garantia, @Cantidad)";

            bool rs = false;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@NombreProducto", NombreProducto),
                    new SqlParameter("@Codigo", Codigo),
                    new SqlParameter("@Costo", Costo),
                    new SqlParameter("@Garantia", Garantia),
                    new SqlParameter("@Cantidad", Cantidad)
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

        public ObjProductos Buscar(string codigo)
        {
            ObjProductos rs = null;

            try
            {
                string query = "SELECT A.Codigo, A.NombreProducto, A.Costo, A.Cantidad, A.Garantia FROM Productos A WHERE A.Codigo = @Codigo";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Codigo", codigo)
                };

                SqlCommand sqlCommand = COMANDO(query, parameters);
                DataTable dataTable = DATATABLE(sqlCommand);

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    rs = new ObjProductos()
                    {
                        Codigo = dataTable.Rows[0].Field<string>("Codigo"),
                        Nombre = dataTable.Rows[0].Field<string>("NombreProducto"),
                        Costo = dataTable.Rows[0].Field<int>("Costo"),
                        Garantia = dataTable.Rows[0].Field<string>("Garantia"),
                        Cantidad = dataTable.Rows[0].Field<string>("Cantidad")
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

        public List<ObjProductos> Listar()
        {
            List<ObjProductos> r = new List<ObjProductos>();
            try
            {
                string query = "SELECT Id, NombreProducto, Codigo, Costo, Garantia, Cantidad FROM Productos";

                SqlDataReader dataReader = DATAREADER(query, null);
                while (dataReader.Read())
                {
                    r.Add(new ObjProductos()
                    {
                        id = dataReader.GetInt32(0),
                        Nombre = dataReader.GetString(1),
                        Codigo = dataReader.GetString(2),
                        Costo = dataReader.GetInt32(3),
                        Garantia = dataReader.GetString(4),
                        Cantidad = dataReader.GetString(5)
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

        public bool eliminarDatos(int id)
        {
            bool rs = false;
            try
            {
                SqlCommand sqlCommand = COMANDO("DELETE FROM Productos WHERE Id=@Id", new List<SqlParameter> { new SqlParameter("@Id", id) });
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
    }
}
