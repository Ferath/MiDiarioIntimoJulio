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
    public partial class ListaDonacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidarLogin();
            if (!IsPostBack)
            {
                
                CargarGrid();
            };
        }

        public void ValidarLogin()
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
            GrdDonacionesTotal.DataSource = from m in DonacionesController.GetAll()
                                            select new
                                            {
                                                Monto = m.monto_donacion,
                                                Metodo = m.Metodopago1.Modalidad
                                            };
            GrdDonacionesTotal.DataBind();
        }

    }
}