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
            if (Session["administrador1"] == null)
            {
                Session["error"] = "Debe iniciar sesión";
                Response.Redirect("login.aspx");
            }

            administrador administrador1 = (administrador)Session["administrador1"];
            //Método validación de Rol
            if (administrador1.rol.id_rol == 1)
            {
                LnkUser.Text = administrador1.nombre+ " " + administrador1.apellido + " (" + administrador1.rol.nombre + ")";
            }
            else
            {
                Session["error"] = "Privilegios insuficientes.";
                Response.Redirect("login.aspx");
            }

        }
    }
}