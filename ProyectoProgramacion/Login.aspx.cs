using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoProgramacion.Controladores;

namespace ProyectoProgramacion.Modelo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Para poder llamar a todos los usuarios
            UsuarioController.GetAll();

            //Recibir mensaje, si es que hay error.
            if (Session["error"] != null)
            {
                LbMensaje.Text = Session["error"].ToString();
                Session["error"] = null;
            }
        }
        protected void BrnLogin_Click(object sender, EventArgs e)
        {
            Administradores administradores = LoginController.login(TxtRut.Text, TxtPassword.Text);
            if (administradores != null)
            {
                Session["administradores"] = administradores;
                Response.Redirect("IndexAdmin.aspx");
            }
            else
            {
                LbMensaje.Text = "Usuario y/o contraseña incorrectos.";

            }
        }
    }
}