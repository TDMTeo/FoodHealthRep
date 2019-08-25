using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Iniciar
{
    public partial class Lista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void lista()
        {
            GvUsuarios.DataSource = Mostrar.ListaPersona();
            GvUsuarios.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GvUsuarios.DataSource = Mostrar.ListaPersona();
            GvUsuarios.DataBind();
        }
    }
}