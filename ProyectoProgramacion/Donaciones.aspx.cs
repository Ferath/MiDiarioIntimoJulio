using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoProgramacion.Controladores;

namespace ProyectoProgramacion
{
    public partial class IndexTesteo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDrp();
            };
        }

        public void CargarDrp()
        {
            DrpMetodoPago.DataSource = from p in MetodopagoController.GetAll()
                                       select new
                                       {
                                           id = p.id,
                                           modalidad = p.Modalidad,
                                       };
            DrpMetodoPago.DataValueField = "id";
            DrpMetodoPago.DataTextField = "Modalidad";
            DrpMetodoPago.DataBind();

        }

        protected void BtnDonar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(5000);
            LbMensaje.Text = DonacionesController.AddDonacion(TxtMonto.Text, DrpMetodoPago.SelectedValue);
        }
    }
}