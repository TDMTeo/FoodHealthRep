using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace Logistica
{
    public partial class Listado_Domiciliario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Lista();
            OcultarDiv();
        }

        private void OcultarDiv()
        {
            Modificar.Visible = false;
        }

        protected void Lista()
        {
            GvUsuarios.DataSource = Mostrar.ListaDomiciliario();
            GvUsuarios.DataBind();
        }

        protected void GvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow fila = GvUsuarios.SelectedRow;
            hdDocumento.Value = fila.Cells[2].Text;
            Campos();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            int DomiciliarioID = int.Parse(hdClientesID.Value);
            string Email = txtEmail.Text;
            string Clave = txtContra.Text;
            string Documento = txtDocumento.Text;
            string Nombre = txtNombre.Text;


            int Registro = ModificarDomiciliario.RegistrarDomi(DomiciliarioID, Documento, Email, Nombre, Clave);

            if (Registro == 3)
            {
                Response.Write("<script>alert('Empleado modificado')</script>");
            }
            else
            {
                Response.Write("<script>alert('Ocurrió un error al modificarse')</script>");
            }

            Limpiar();
            OcultarDiv();

        }

        public void Limpiar()
        {
            txtEmail.Text = string.Empty;
            txtContra.Text = string.Empty;
            txtDocumento.Text = string.Empty;
            txtNombre.Text = string.Empty;

        }

        private void Campos()
        {
            string Documento = hdDocumento.Value;
            Domiciliario domiciliario = ModificarDomiciliario.BuscarPorCedula(Documento);
            hdClientesID.Value = domiciliario.DomiciliarioID.ToString();
            txtEmail.Text = domiciliario.Correo;
            txtContra.Text = domiciliario.Contraseña;
            txtDocumento.Text = domiciliario.Documento;
            txtNombre.Text = domiciliario.Nombre;

            Modificar.Visible = true;
        }
    }
}
