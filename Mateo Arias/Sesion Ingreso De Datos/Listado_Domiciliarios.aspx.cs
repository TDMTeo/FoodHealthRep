using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Logistica
{
    public partial class Listado_Domiciliarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GvDomiciliarios.DataSource = Mostrar.ListaDomiciliario();
            GvDomiciliarios.DataBind();
        }

        protected void GvDomiciliarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            GvDomiciliarios.DataSource = Mostrar.ListaDomiciliario();
            GvDomiciliarios.DataBind();
            GridViewRow fila = GvDomiciliarios.SelectedRow;
            String nombre = fila.Cells[2].Text;
            Response.Write("<script>alert(" + nombre + ")</script>");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Administrador.aspx");
        }
    }
}