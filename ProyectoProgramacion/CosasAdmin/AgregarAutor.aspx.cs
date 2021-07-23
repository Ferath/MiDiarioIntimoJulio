using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoProgramacion.Controladores;
using ProyectoProgramacion.Modelo;


namespace ProyectoProgramacion.CosasAdmin
{
    public partial class AgregarAutor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDrp();
            };
        }
        public void validarLogin()
        {

            //Método de validación de Session.
            if (Session["administradores"] == null)
            {
                Session["error"] = "Debe iniciar sesión";
                Response.Redirect("../login.aspx");
            }

            Administradores administradores = (Administradores)Session["administradores"];
            //Método validación de Rol
            if (administradores.rol_usuario == 1)
            {
            }
            else
            {
                Session["error"] = "Privilegios insuficientes.";
                Response.Redirect("../login.aspx");
            }

        }



        // Cargando las personas creadas por el administrador
        public void CargarDrp()
        {

            DrpPersonas.DataSource = from p in PersonaController.GetAllPersona()
                                  select new
                                  {
                                      nombre = p.nombre + " " + p.apellido,
                                      id_persona = p.id_persona
                                  };
            DrpPersonas.DataValueField = "id_persona";
            DrpPersonas.DataTextField = "Nombre";
            DrpPersonas.DataBind();
        }

        // Creando un autor
        protected void BtnBtnAgregarAutor_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(5000);
            LbMensaje.Text = AutorController.AddAutor(DrpPersonas.SelectedValue);
            Response.Redirect("CrearNoticia.aspx");
        }
    }
}