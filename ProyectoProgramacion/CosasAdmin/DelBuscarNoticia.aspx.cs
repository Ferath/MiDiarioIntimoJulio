using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoProgramacion.Controladores;

namespace ProyectoProgramacion.Admin
{
    public partial class DelBuscarNoticia : System.Web.UI.Page
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
            GrdNoticias.DataSource = from n in NoticiaController.GetAll()
                                            select new
                                            {
                                                ID = n.id,
                                                Titulo = n.titulo_noticia,
                                                Fecha = n.fecha_noticia.ToShortDateString(),
                                                Autor = n.Autor1.nombre + " " + n.Autor1.apellido,
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