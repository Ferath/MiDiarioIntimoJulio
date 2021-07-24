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
    public partial class CrudAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDrp();
            };
        }

        // Cargando las Personas que el admin previamente creo
        public void CargarDrp()
        {

            DrpPersonas.DataSource = from p in PersonaController.GetAllPersona()
                                     select new
                                     {
                                         nombre = p.rut + " | " + p.nombre + " " + p.apellido,
                                         id = p.id_persona
                                     };
            DrpPersonas.DataValueField = "id";
            DrpPersonas.DataTextField = "Nombre";
            DrpPersonas.DataBind();
        }

        // Creando un administrador
        protected void BtnAgregarAdmin_click(object sender, EventArgs e)
        {
            LbMensaje.Text = UsuarioController.AddAdministrador(TxtUsername.Text, DrpPersonas.SelectedValue, TxtPassword.Text, "1");
        }
    }
}