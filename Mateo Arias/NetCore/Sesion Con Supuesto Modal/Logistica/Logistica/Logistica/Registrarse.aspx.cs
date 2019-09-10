using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace Logistica
{
    public partial class Pruebas1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(txtContra.Text.Equals(String.Empty) | txtDocumento.Text.Equals(String.Empty) | txtEmail.Text.Equals(String.Empty) || txtNombre.Text.Equals(String.Empty) || txtDireccion.Text.Equals(String.Empty))
            {
                Response.Write("<script>alert('Ingrese Todos Los Datos')</script>");
            }
            else
            {
                String Documento = txtDocumento.Text;
                String Correo = txtEmail.Text;
                String Nombre = txtNombre.Text;
                String Direccion = txtDireccion.Text;
                String Contraseña = txtContra.Text;

                int resultado = Registrar_Usuario.RegistrarUsuario(Documento, Correo, Nombre, Direccion, Contraseña);

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
                    Response.Redirect("Iniciar.aspx");
                }

                Limpiar();
            }
            
          
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cliente.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Iniciar.aspx");
        }

        public void Limpiar()
        {
            txtDocumento.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtContra.Text = string.Empty;
        }
    }
}