using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExamenFinal.capa_logica;
using ExamenFinal.capa_modelo;

namespace ExamenFinal.capa_vista
{
    public partial class Formulario_web12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }
        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Asignaciones"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }
        public static void MostrarAlerta(Page page, string message)
        {
            string script = $"<script type='text/javascript'>alert('{message}');</script>";
            ClientScriptManager cs = page.ClientScript;
            cs.RegisterStartupScript(page.GetType(), "AlertScript", script);
        }

       

        

        protected void Agregar_Click1(object sender, EventArgs e)
        {

            CLSasignacion.Empleadoid = int.Parse(Eid.Text);
            CLSasignacion.Proyectoid = int.Parse(Pid.Text);
            CLSasignacion.FechaAsig = FechaA.Text;


            if ((Asignaciones.AgregarAsignacion(CLSasignacion.Empleadoid, CLSasignacion.Proyectoid, CLSasignacion.FechaAsig) > 0))
            {
                MostrarAlerta(this, "Asignacion ingresada");

                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al ingresar Asignacion");
            }
        }

        protected void Borrar_Click1(object sender, EventArgs e)
        {

            CLSasignacion.id = int.Parse(id.Text);



            if (Proyectos.EliminarProyecto(CLSproyectos.id) > 0)
            {
                MostrarAlerta(this, "Asignacion Borrada");
                id.Text = "";
                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al borrar Asignacion");
            }
        }
    }
}