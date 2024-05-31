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
    public class DBProductos:ConexDB
    {
        public bool Guardar(int id, string NombreProducto, int Codigo,  int Costo, string Garantia, string Cantidad)
        {
            string query = id > 0 ?
                "UPDATE Productos SET NombreProducto=@NombreProducto, Codigo=@Codigo, Costo=@Costo, Garantia=@Garantia, Cantidad=@Cantidad WHERE Id=@Id" :
                "INSERT INTO Productos (NombreProducto,Codigo, Costo, Garantia, Cantidad) VALUES (@NombreProducto, @Codigo , @Costo, @Garantia, @Cantidad)";

            bool rs = false;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Nombre", NombreProducto),
                    new SqlParameter("@Codigo", Codigo),
                    new SqlParameter("@Precio", Costo),
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



        /*BUSCAR---------------------------*/
        public ObjProductos Buscar(string codigo)
        {
            ObjProductos rs = null;

            try
            {
                string query = "SELECT A.Codigo, A.NombreProducto, A.Costo, A.Cantidad, A.Garantia FROM Productos A WHERE A.Codigo = " + codigo;

                sqlCommand = COMANDO(query, null);
                dataTable = DATATABLE(sqlCommand);
                if (dataTable != null || dataTable.Rows.Count > 0)
                {

                    rs = new ObjProductos()
                    {
                        Nombre = dataTable.Rows[0].Field<string>("NombreProducto"),
                        Costo = dataTable.Rows[0].Field<int>("Costo"),
                        Garantia = dataTable.Rows[0].Field<string>("Garantia"),
                        Cantidad = dataTable.Rows[0].Field<string>("Cantidad"),
                        Codigo = dataTable.Rows[0].Field<string >("Codigo")

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

        //Listar-----------------------------
        public List<Modelos.ObjProductos> Listar()
        {
            List<Modelos.ObjProductos> r = new List<Modelos.ObjProductos>();
            try
            {
                string query = @"SELECT p.Id, p.NombreProducto AS Producto, p.Costo,
                                 p.Codigo,
                                 FROM Productos p ";

                SqlDataReader dataReader = DATAREADER(query, null);
                while (dataReader.Read())
                {
                    r.Add(new Modelos.ObjProductos()
                    {
                        id = dataReader.GetInt32(0),
                        Nombre = dataReader.GetString(1),
                        Costo = dataReader.GetInt32(2),
                        Codigo = dataReader.GetString(3),
                        Cantidad = dataReader.GetString(4),
                        Garantia = dataReader.GetString(5)
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

        /*ELIMINAR DATOS A LA BASE DE DATOS------------------------------------------------------------*/

        public bool eliminarDatos(int id)
        {
            bool rs = false;
            try
            {
                sqlCommand = COMANDO("DELETE FROM Productos WHERE Id=" + id, null);
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
