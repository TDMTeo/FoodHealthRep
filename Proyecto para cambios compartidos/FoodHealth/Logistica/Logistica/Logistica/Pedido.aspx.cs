using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace Logistica
{
    public partial class Pruebas3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Administrador.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text.Equals(String.Empty) | txtDomi.Text.Equals(String.Empty) | txtDireccion.Text.Equals(String.Empty) | txtDescripcion.Text.Equals(String.Empty))
            {
                Response.Write("<script>alert('Ingrese Todos Los Datos')</script>");
            }
            else
            {
                String Cliente = txtCliente.Text;
                String Domi = txtDomi.Text;
                String Direccion = txtDireccion.Text;
                String Descripcion = txtDescripcion.Text;
                int resultado = Agregar_Pedido.RegistrarPedido(Cliente, Domi, Direccion, Descripcion);

                if (resultado == 1)
                {
                    Response.Write("<script>alert('Cliente No Existente')</script>");
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

        }
        public void Limpiar()
        {
            txtCliente.Text = string.Empty;
            txtDomi.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
        }

    }
}