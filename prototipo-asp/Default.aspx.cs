using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace prototipo_asp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["listaDirecciones"] == null)
            {
                DireccionNegocio negocio = new DireccionNegocio();
                Session.Add("listaDirecciones", negocio.listar());
            }

            dgvDirecciones.DataSource = Session["listaDirecciones"];
            dgvDirecciones.DataBind();

        }

        protected void dgvDirecciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = dgvDirecciones.SelectedDataKey.Value.ToString();
            Response.Redirect("DireccionForm.aspx?id=" + id);
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("DireccionForm.aspx");
        }
    }
}