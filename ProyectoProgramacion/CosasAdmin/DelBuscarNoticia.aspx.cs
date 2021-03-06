using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoProgramacion.Controladores;
using ProyectoProgramacion.Modelo;

namespace ProyectoProgramacion.Admin
{
    public partial class DelBuscarNoticia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            validarLogin();
            if (!IsPostBack)
            {
                CargarGrid();
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
            if (administradores.rol.id_rol == 1)
            {
            }
            else
            {
                Session["error"] = "Privilegios insuficientes.";
                Response.Redirect("../login.aspx");
            }

        }
        public void CargarGrid()
        {
            GrdNoticias.DataSource = from n in NoticiaController.GetAll()
                                            select new
                                            {
                                                ID = n.id,
                                                Titulo = n.titulo_noticia,
                                                Fecha = n.fecha_noticia.ToShortDateString(),
                                                Autor = n.Autor1.Persona.nombre + " " + n.Autor1.Persona.apellido,
                                            };
            GrdNoticias.DataBind();
        }

        protected void BtnEliminarNoticia_Click(object sender, EventArgs e)
        {
            LbBorrar.Text = NoticiaController.RemoveNoticia(TxtBuscarNoticia.Text);
            CargarGrid();
        }
    }
}