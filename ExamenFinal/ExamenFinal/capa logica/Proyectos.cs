using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ExamenFinal.capa_logica
{
    public class Proyectos
    {
        public static int AgregarProyecto(string codigo, string nombre, string Fechainicio, string Fechafin)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("AgregarProyectos", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new SqlParameter("@codigo", codigo));
                    cmd.Parameters.Add(new SqlParameter("@Nombre", nombre));
                    cmd.Parameters.Add(new SqlParameter("@fechainicio", Fechainicio));
                    cmd.Parameters.Add(new SqlParameter("@fechafin", Fechafin));


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
        public static int EliminarProyecto(int id)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("borararProyecto", Conn)
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