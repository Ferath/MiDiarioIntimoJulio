using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoProgramacion.Controladores;


namespace ProyectoProgramacion.Admin
{
    public partial class CrearNoticia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDrp();
            };
            
        }
        // Cargando el Dropdown de los autores registrados
        public void CargarDrp()
        {

            DrpAutor.DataSource = from p in AutorController.GetAll()
                                    select new
                                    {
                                        nombre = p.nombre + " " + p.apellido,
                                        id = p.id
                                    };
            DrpAutor.DataValueField = "id";
            DrpAutor.DataTextField = "Nombre";
            DrpAutor.DataBind();
        }
        // Creando una Noticia
        protected void BtnSubirNoticia_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(5000);
            LbMensaje.Text = NoticiaController.AddNoticia(TxtTitulo.Text, TxtFechaMostrar.Text, DrpAutor.SelectedValue, TxtDescripcion.Text);
        }

        protected void TxtFechaMostrar_PreRender(object sender, EventArgs e)
        {
            TxtFechaMostrar.Text = DateTime.Now.ToShortDateString();

        }
    }
}