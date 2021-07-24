using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoProgramacion.Controladores;
using ProyectoProgramacion.Modelo;
using System.Drawing;


namespace ProyectoProgramacion.CosasAdmin
{
    public partial class AgregarAutor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            validarLogin();
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
                                      nombre = p.id_persona + ".- " + p.nombre + " " + p.apellido,
                                      id = p.id_persona
                                  };
            DrpPersonas.DataValueField = "id";
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

        protected void LnkNuevo_Click(object sender, EventArgs e)
        {
            if (LnkVer.Text.Equals("Agregar nueva persona"))
            {
                PanelPersona.Visible = true;
                TxtNombre.Visible = true;
                TxtNombre.Enabled = true;
                TxtRut.Enabled = true;
                TxtRut.Visible = true;
                TxtApellido.Visible = true;
                TxtApellido.Enabled = true;
                BtnCrearPersona.Visible = true;
                LnkVer.Text = "Cancelar";
            }
            else
            {
                PanelPersona.Visible = false;
                TxtNombre.Visible = false;
                TxtNombre.Enabled = false;
                TxtRut.Enabled = false;
                TxtRut.Visible = false;
                TxtApellido.Visible = false;
                TxtApellido.Enabled = false;
                BtnCrearPersona.Visible = false;
                LnkVer.Text = "Agregar nueva persona";
            }
        }

        protected void BtnCrearPersona_Click(object sender, EventArgs e)
        {
            LbMensaje2.Text = PersonaController.AddPersona(TxtNombre.Text, TxtApellido.Text, TxtRut.Text);
            Console.WriteLine(LbMensaje2.Text);
            System.Threading.Thread.Sleep(5000);
            Response.Redirect("~/CosasAdmin/AgregarAutor.aspx");

        }

        protected void DelPersona(object sender, EventArgs e)
        {
            LbMensaje.Text = PersonaController.RemovePersona(DrpPersonas.SelectedValue);
            System.Threading.Thread.Sleep(5000);
            Response.Redirect("~/CosasAdmin/AgregarAutor.aspx");
        }
    }
}