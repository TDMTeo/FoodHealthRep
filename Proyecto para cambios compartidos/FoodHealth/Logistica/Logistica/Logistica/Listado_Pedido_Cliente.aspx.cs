using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;
namespace Logistica
{
    public partial class Listado_Pedido_Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GvUsuarios.DataSource = Mostrar.ListaPedidoscliente();
            GvUsuarios.DataBind();
        }

        protected void GvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}