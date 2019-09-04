using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;
namespace Logistica
{
    public partial class Listado_Rol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GvUsuarios.DataSource = Mostrar.ListaRol();
            GvUsuarios.DataBind();
        }

        protected void GvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            GvUsuarios.DataSource = Mostrar.ListaRol();
            GvUsuarios.DataBind();
            GridViewRow fila = GvUsuarios.SelectedRow;
            String Rol = fila.Cells[0].Text;
            Response.Write("<script>alert(" + Rol + ")</script>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GvUsuarios.DataSource = Mostrar.ListaRol();
            GvUsuarios.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Administrador.aspx");
        }
    }
}