using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace Logistica
{
    public partial class Pruebas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String user = txtCorr.Text;
            String pass = txtContr.Text;
            String vacio = string.Empty;
            int Rol = Iniciar_Sesion.IniciarSesion(user, pass);
            if (txtCorr.Text == vacio) 
            {
                Response.Write("<script>alert('Ingrese Su Correo.')</script>");
            }

            else 
                if (txtContr.Text == vacio)
            {
                Response.Write("<script>alert('Ingrese Su Clave')</script>");
            }

            else
            {
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
                        Response.Write("<script> alert ('Error, Verifica bien tus datos. '); window.location = 'Inicio.aspx' </script>");
                        Response.Redirect("Pruebas.aspx");
                        break;
                }


            }

            Limpiar();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registrarse.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cliente.aspx");
        }

        public void Limpiar()
        {
            txtCorr.Text = String.Empty;
            txtContr.Text = String.Empty;
        }
    }
}