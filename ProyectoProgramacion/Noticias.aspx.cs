using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoProgramacion.Controladores;

namespace ProyectoProgramacion
{
    public partial class Noticias : System.Web.UI.Page
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
            GrdListadoNoticias.DataSource = from n in NoticiaController.GetAll()
                                            select new
                                            {
                                                Titulo = n.titulo_noticia,
                                                Fecha = n.fecha_noticia.ToShortDateString(),
                                                Autor = n.Autor1.nombre+" "+n.Autor1.apellido,
                                                Descripcion = n.descripcion_noticia
                                            };
            GrdListadoNoticias.DataBind();
        }
        
    }
}