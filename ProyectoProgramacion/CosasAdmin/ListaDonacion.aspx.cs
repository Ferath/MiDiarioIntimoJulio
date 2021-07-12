using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoProgramacion.Controladores;

namespace ProyectoProgramacion.Admin
{
    public partial class ListaDonacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrid();
            };
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