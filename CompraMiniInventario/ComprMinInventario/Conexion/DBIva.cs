using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    public class DBIva : ConexDB
    {
        public bool Guardar(int id, int Porcentaje)
        {
            string query = id > 0 ?
                "UPDATE Productos SET Porcentaje=@Porcentaje WHERE Id=@Id" :
                "INSERT INTO Productos (Porcentaje) VALUES (@Porcentaje)";

            bool rs = false;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Porcentaje", Porcentaje)

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
        public objIva Buscar(int Porcentaje)
        {
            objIva rs = null;

            try
            {
                string query = "SELECT A.Porcentaje FROM Iva A WHERE A.Porcentaje = " + Porcentaje;

                sqlCommand = COMANDO(query, null);
                dataTable = DATATABLE(sqlCommand);
                if (dataTable != null || dataTable.Rows.Count > 0)
                {

                    rs = new objIva()
                    {
                        Porcentaje = dataTable.Rows[0].Field<int>("Porcentaje"),

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
        public List<Modelos.objIva> Listar()
        {
            List<Modelos.objIva> r = new List<Modelos.objIva>();
            try
            {
                string query = @"SELECT p.Id, p.Porcentaje
                                 FROM Iva p ";

                SqlDataReader dataReader = DATAREADER(query, null);
                while (dataReader.Read())
                {
                    r.Add(new Modelos.objIva()
                    {
                        id = dataReader.GetInt32(0),
                        Porcentaje = dataReader.GetInt32(1),
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
                sqlCommand = COMANDO("DELETE FROM Iva WHERE Id=" + id, null);
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
