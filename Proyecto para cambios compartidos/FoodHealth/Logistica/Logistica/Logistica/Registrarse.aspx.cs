using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;
namespace Logistica
{
    public partial class Registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String Documento = txtDocumento.Text;
            String Correo = txtCorreo.Text;
            String Nombre = txtNombre.Text;
            String Direccion = txtDireccion.Text;
            String Contraseña = txtContraseña.Text;

            int resultado = Registrar.RegistrarUsuario(Documento, Correo, Nombre, Direccion,Contraseña);

            if (resultado == 1)
            {
                Response.Write("<script>alert('Usuario ya existente')</script>");
            }
            else
                if (resultado == 2)
            {
                Response.Write("<script>alert('Verifica bien tus datos y vuelve a intentarlo')</script>");
            }
            else
            {
                Response.Write("<script>alert('Registro Exitoso')</script>");
            }

            Limpiar();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Iniciar.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cliente.aspx");
        }

        public void Limpiar()
        {
            txtDocumento.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtContraseña.Text = string.Empty;
        }
    }
}