using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExamenFinal.capa_modelo;
using ExamenFinal.capa_logica;

namespace ExamenFinal.capa_vista
{
    public partial class Formulario_web11 : System.Web.UI.Page
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
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Proyectos"))
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

        protected void Agregar_Click(object sender, EventArgs e)
        {
           
            CLSproyectos.codigo =Codigo.Text;
            CLSproyectos.nombre =Nombre.Text;
            CLSproyectos.Fechainicio = Fechainicio.Text;
            CLSproyectos.Fechafin = fechafin.Text;

            if ((Proyectos.AgregarProyecto(CLSproyectos.codigo,CLSproyectos.nombre,CLSproyectos.Fechainicio,CLSproyectos.Fechafin) > 0))
            {
                MostrarAlerta(this, "Proyecto ingresado");
               
                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al ingresar proyecto");
            }
        }
        protected void Borrar_Click(object sender, EventArgs e)
        {
            CLSproyectos.id= int.Parse(id.Text);



            if (Proyectos.EliminarProyecto(CLSproyectos.id) > 0)
            {
                MostrarAlerta(this, "Proyecto Borrado");
                id.Text = "";
                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al borrar proyecto");
            }

        }
    }
}