using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Logistica
{
    public partial class Listado_Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GvClientes.DataSource = Mostrar.ListaCliente();
            GvClientes.DataBind();
        }

        protected void GvClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            GvClientes.DataSource = Mostrar.ListaCliente();
            GvClientes.DataBind();
            GridViewRow fila = GvClientes.SelectedRow;
            String nombre = fila.Cells[2].Text;
            Response.Write("<script>alert(" + nombre + ")</script>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Administrador.aspx");
        }
    }
}