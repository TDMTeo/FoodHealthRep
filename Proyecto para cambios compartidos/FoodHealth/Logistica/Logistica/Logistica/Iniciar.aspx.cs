using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;
namespace Logistica
{
    public partial class Iniciar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String user = txtNombre.Text;
            String pass = txtContra.Text;
            int Rol = Conexion.IniciarSesion(user, pass);
            switch (Rol)
            {
                case 1:
                    Response.Write("<script>alert('Welcome Cliente'); window.location = 'Usuario.aspx' </script> ");
                    Response.Redirect("Usuario.aspx");
                    break;
                case 2:
                    Response.Write("<script>alert('Welcome Administrador'); window.location = 'Administrador.aspx' </script>");
                    Response.Redirect("Administrador.aspx");
                    break;

                case 3:
                    Response.Write("<script>alert('Welcome Domiciliario'); window.location = 'Domiciliario.aspx' </script>");
                    Response.Redirect("Domiciliario.aspx");
                    break;

                default:
                    Response.Write("<script> alert ('Error Nel Pte '); window.location = 'Inicio.aspx' </script>");
                    break;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registrarse.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cliente.aspx");
        }
    }
}