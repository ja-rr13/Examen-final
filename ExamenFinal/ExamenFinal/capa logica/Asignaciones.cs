using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ExamenFinal.capa_logica
{
    public class Asignaciones
    {
        public static int AgregarAsignacion(  int Empleadoid , int Proyectoid, string FechaAsig)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("AgregarAsignacion", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new SqlParameter("@Empleadoid", Empleadoid));
                    cmd.Parameters.Add(new SqlParameter("@Proyectoid", Proyectoid));
                    cmd.Parameters.Add(new SqlParameter("@fechaAsignacion", FechaAsig));
                   


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
        public static int EliminarAsignacion(int id)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("borararAsignacion", Conn)
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