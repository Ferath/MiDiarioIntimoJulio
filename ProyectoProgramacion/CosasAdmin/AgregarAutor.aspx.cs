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
            validarLogin();
        }
        public void validarLogin()
        {

            //Método de validación de Session.
            if (Session["administrador1"] == null)
            {
                Session["error"] = "Debe iniciar sesión";
                Response.Redirect("../login.aspx");
            }

            administrador administrador1 = (administrador)Session["administrador1"];
            //Método validación de Rol
            if (administrador1.rol.id_rol == 1)
            {
            }
            else
            {
                Session["error"] = "Privilegios insuficientes.";
                Response.Redirect("../login.aspx");
            }

        }
        // Creando una Noticia
        protected void BtnBtnAgregarAutor_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(5000);
            LbMensaje.Text = AutorController.AddAutor(TxtNombre.Text, TxtApellido.Text, TxtRut.Text);
            Response.Redirect("CrearNoticia.aspx");
        }

    }
}