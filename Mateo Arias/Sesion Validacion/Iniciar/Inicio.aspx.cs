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
            int Rol = 0;
            Rol = Rol + 1;
            int UserID = Modelo.IniciarSesion(user, pass, Rol);
            
            if (UserID == 0)
            {
                Response.Write("<Script> 'Datos Incorrectos' <Script> ");
            }
            else
            {
                Response.Write("<Script> 'Datos Correctos' <Script> ");
               if (Rol == 1)
                {
                    Response.Redirect("Administrador.aspx");
                }
               else
                {
                    Response.Redirect("Natural.aspx");
                }
            }

        }
    }
}