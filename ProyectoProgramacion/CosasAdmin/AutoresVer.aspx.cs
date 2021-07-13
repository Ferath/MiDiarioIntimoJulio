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
    public partial class AutoresVer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            Autor autor = AutorController.FindAutor(TxtBuscar.Text);
            if (autor != null)
            {
                LbMensaje.Text = "Autor encontrado";
                LbMensaje.ForeColor = Color.Green;
                Panel1.Visible = true;

                Hdnid.Value = autor.id.ToString();//Valor oculto

                TxtRut.Text = autor.rut;
                TxtNombre.Text = autor.nombre;
                TxtApellido.Text = autor.apellido;

                Session["aut"] = autor;

            }
            else
            {
                LbMensaje.Text = "Autor no encontrado";
                LbMensaje.ForeColor = Color.Red;
                Panel1.Visible = false;
            }
        }

        protected void LnkEditar_Click(object sender, EventArgs e)
        {

            if (LnkEditar.Text.Equals("Modificar"))
            {
                TxtNombre.Enabled = true;
                TxtApellido.Enabled = true;
                BtnModificar.Visible = true;
                LnkEditar.Text = "Cancelar";
            }
            else
            {
                TxtNombre.Enabled = false;
                TxtApellido.Enabled = false;
                BtnModificar.Visible = false;
                LnkEditar.Text = "Modificar";
            }
        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            
            LbMensaje2.Text = AutorController.EditAutor(Hdnid.Value, TxtNombre.Text, TxtApellido.Text, TxtRut.Text);
            Autor autor1 = (Autor)Session["aut"];
            Console.WriteLine(LbMensaje2.Text);

        }
        protected void LnkNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarAutor.aspx");
        }
    }
}