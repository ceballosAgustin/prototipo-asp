using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace prototipo_asp
{
    public partial class DireccionForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Direccion> listaDirecciones = (List<Direccion>)Session["listaDirecciones"];

                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"].ToString());

                    Direccion seleccionado = listaDirecciones.Find(x => x.Id == id);

                    txtId.Text = seleccionado.Id.ToString();
                    txtId.ReadOnly = true;
                    txtId.Enabled = false;

                    txtCalle.Text = seleccionado.Calle;
                    // txtCalle.ReadOnly = true;
                    // txtCalle.Enabled = false;

                    txtAltura.Text = seleccionado.Altura.ToString();
                    // txtAltura.ReadOnly = true;
                    // txtAltura.Enabled = false;

                    btnAceptar.Enabled = false;
                
                }

                if (Request.QueryString["id"] == null)
                {
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;

                }
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Direccion d = new Direccion();
            d.Id = int.Parse(txtId.Text);
            d.Calle = txtCalle.Text;
            d.Altura = int.Parse(txtAltura.Text);

            List<Direccion> temporal = (List<Direccion>)Session["listaDirecciones"];
            temporal.Add(d);

            Response.Redirect("Default.aspx");
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);

            List<Direccion> temporal = (List<Direccion>)Session["listaDirecciones"];
            Direccion direccion = temporal.Find(x => x.Id == id);

            if(direccion != null)
            {
                direccion.Calle = txtCalle.Text;
                direccion.Altura = int.Parse(txtAltura.Text);


                Response.Redirect("Default.aspx");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            List<Direccion> listaDirecciones = (List<Direccion>)Session["listaDirecciones"];
            int id = int.Parse(txtId.Text);

            Direccion direccion = listaDirecciones.Find(d => d.Id == id);

            if (direccion != null)
            {
                listaDirecciones.Remove(direccion);

                Response.Redirect("Default.aspx");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

    }
}