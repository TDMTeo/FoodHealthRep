using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            String Nombre = txtNombre.Text;
            String Correo = txtCorreo.Text;
            String Direccion = txtDireccion.Text;

            int resultado = Registrar.RegistrarUsuario(Documento, Correo, Nombre, Direccion);

            if (resultado == 1)
            {
                Response.Write("<script>alert('Upps Ya Exist')</script>");
            }
            else
                if(resultado == 2)
            {
                Response.Write("<script>alert('We have a problem')</script>");
            }
            else
            {
                Response.Write("<script>alert('Fuck yeah te has registrado')</script>");
            }
        }
    }
}