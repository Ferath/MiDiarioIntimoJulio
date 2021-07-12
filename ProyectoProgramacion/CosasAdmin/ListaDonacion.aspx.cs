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
            validarLogin();
            if (!IsPostBack)
            {
                
                CargarGrid();
            };
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