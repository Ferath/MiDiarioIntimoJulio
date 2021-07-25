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
    public partial class Noticias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NoticiasDiferente();
            };
        }
        
        public void NoticiasDiferente()
        {
            string html = "";
            foreach (Noticia noticias in NoticiaController.GetAll())
            {
                html += "<article class=\"don-container mb-4 \"><div class=\"row\"><div class=\"col d-flex px-0 mb-3\"><img src = \"https://via.placeholder.com/150x100\"><div class=\"title d-flex flex-column\"><h2>" + noticias.titulo_noticia + "</h2></div></div>";
                html += "<div class=\"date-con col text-end\"><p><span> Subido el </span><br>" + noticias.fecha_noticia.ToShortDateString() + "</p></div> ";
                html += "<div class=\"date-con col text-end\"><p><span> Subido por </span><br>" + noticias.Autor1.Persona.nombre + " " + noticias.Autor1.Persona.apellido + "</p></div> ";
                html += "<div class=\"descripcion mb-4\"><p>" + noticias.descripcion_noticia + "</p></div>";
            }

            NoticiasContainer.InnerHtml = html;
        }

    }
}