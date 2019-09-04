using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace Logistica
{
    public partial class Pruebas2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Rol = 0;
            String Documento = txtDocumento.Text;
            String Nombre = txtNombre.Text;
            String Correo = txtEmail.Text;
            String Direccion = txtDireccion.Text;
            String contraseña = txtContra.Text;

            if (RadioCliente.Checked == true)
            {
                Rol = 1;
                int resultado = Registrar_Cliente.RegistrarCliente(Documento, Correo, Nombre, Direccion, contraseña, Rol);

                if (resultado == 1)
                {
                    Response.Write("<script>alert('Usuario ya existente')</script>");
                }
                else
                    if (resultado == 2)
                {
                    Response.Write("<script>alert('Verifica bien los datos')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Registro Exitoso')</script>");
                }
            }
            if (RadioAdmin.Checked == true)
            {
                Rol = 2;
                int resultado = Registrar_Domi.RegistrarDomi(Documento, Correo, Nombre, contraseña, Rol);

                if (resultado == 1)
                {
                    Response.Write("<script>alert('Usuario ya existente')</script>");
                }
                else
                    if (resultado == 2)
                {
                    Response.Write("<script>alert('Verifica bien los datos')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Registro Exitoso')</script>");
                }
            }

            Limpiar();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Administrador.aspx");
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