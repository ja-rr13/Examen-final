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
    public partial class Formulario_web1 : System.Web.UI.Page
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
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Empleados"))
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

            CLSempleado.NumeroC = NumeroC.Text;
            CLSempleado.Nombre = Nombre.Text;
            CLSempleado.FechaNaci = Fecha.Text;
            CLSempleado.Categoria = categoria.Text;
            CLSempleado.salario = salario.Text;
            CLSempleado.Direccion = Direc.Text;
            CLSempleado.telefono = Tel.Text;
            CLSempleado.Correo = correo.Text;


            if ((Empleados.AgregarEmpleado(CLSempleado.NumeroC, CLSempleado.Nombre, CLSempleado.FechaNaci, CLSempleado.Categoria, CLSempleado.salario, CLSempleado.Direccion, CLSempleado.telefono, CLSempleado.Correo) > 0))
            {
                MostrarAlerta(this, "Empleado ingresado");

                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al ingresar Empleado");
            }
        }

        protected void Borrar_Click1(object sender, EventArgs e)
        {
            CLSempleado.id = int.Parse(id.Text);



            if ((Empleados.EliminarEmpleado(CLSempleado.id)) > 0)
            {
                MostrarAlerta(this, "Empleado Borrado");

                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al borrar Empleado");
            }
        }

        protected void Consultar_Click(object sender, EventArgs e)
        {

            CLSempleado.id = int.Parse(id.Text);

            if (Empleados.ConsultarEmpleado(CLSempleado.id) > 0)
            {
                MostrarAlerta(this, "Empleado encontrado");

                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Empleado no encontrado");
            }
        }
    }
}