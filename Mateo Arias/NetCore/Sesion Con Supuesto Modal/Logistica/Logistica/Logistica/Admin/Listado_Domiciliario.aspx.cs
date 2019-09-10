using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace Logistica
{
    public partial class Listado_Domiciliario : System.Web.UI.Page
    {
        public string nombre;
        public int Rol;
        protected void Page_Load(object sender, EventArgs e)
        {
            GvUsuarios.DataSource = Mostrar.ListaDomiciliario(nombre,Rol);
            GvUsuarios.DataBind();
        }

        protected void GvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            GvUsuarios.DataSource = Mostrar.ListaDomiciliario(nombre, Rol);
            GvUsuarios.DataBind();
            //GridViewRow fila = GvUsuarios.SelectedRow;
            //String nombre = fila.Cells[2].Text;
            Response.Write("<script>alert(" + Rol + ""+ ")</script>");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GvUsuarios.DataSource = Mostrar.ListaDomiciliario(nombre, Rol);
            GvUsuarios.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Administrador.aspx");
        }
    }
}