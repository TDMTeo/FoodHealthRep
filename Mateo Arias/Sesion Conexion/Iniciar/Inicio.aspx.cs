using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Iniciar

{

    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Button1_Click(object sender, EventArgs e)
        {

            String user = txtNombre.Text;
            String pass = txtContra.Text;
            int UserID = Modelo.IniciarSesion(user, pass);
            if (UserID == 0)
            {
                Response.Write("<Script> 'Datos Incorrectos' <Script> ");
                Response.Redirect("Natural.aspx");
            }
            else
            {
                Response.Write("<Script> 'Datos Incorrectos' <Script> ");
                Response.Redirect("Administrador.aspx");
            }

        }
    }
}