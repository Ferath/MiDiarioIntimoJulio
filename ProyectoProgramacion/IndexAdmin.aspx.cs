using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoProgramacion.Controladores;
using ProyectoProgramacion.Modelo;

namespace ProyectoProgramacion
{
    public partial class Administrador1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            validarLogin();
        }
        public void validarLogin()
        {

            //Método de validación de Session.
            if (Session["administradores"] == null)
            {
                Session["error"] = "Debe iniciar sesión";
                Response.Redirect("login.aspx");
            }

            Administradores administradores = (Administradores)Session["administradores"];
            //Método validación de Rol
            if (administradores.rol.id_rol == 1)
            {
                LnkUser.Text = administradores.Persona.nombre+ " " + administradores.Persona.apellido + " (" + administradores.rol.nombre + ")" + " ( Su RUT es" + administradores.Persona.rut + ")";
            }
            else
            {
                Session["error"] = "Privilegios insuficientes.";
                Response.Redirect("login.aspx");
            }

        }
    }
}