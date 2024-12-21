using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ExamenFinal.capa_logica
{
    public class Empleados
    {
        public static int AgregarEmpleado( string Numeroc, string nombre, string fechanaci,string categoria,string salario,string direccion,string telefono,string correo)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("AgregarEmpleado", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new SqlParameter("@num", Numeroc));
                    cmd.Parameters.Add(new SqlParameter("@Nombre", nombre));
                   
                    cmd.Parameters.Add(new SqlParameter("@fecha", fechanaci));

                    cmd.Parameters.Add(new SqlParameter("@cat", categoria));
                    cmd.Parameters.Add(new SqlParameter("@sal", salario));
                    cmd.Parameters.Add(new SqlParameter("@direc", direccion));
                    cmd.Parameters.Add(new SqlParameter("@telefono", telefono));
                    cmd.Parameters.Add(new SqlParameter("@Correo", correo));


                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
        public static int EliminarEmpleado(int id)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("borarEmpleado", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new SqlParameter("@id", id));




                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
       
        public static int ConsultarEmpleado(int id)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("consultarEmpleado", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new SqlParameter("@id", id));




                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
    }
}