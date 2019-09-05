using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace Logistica
{
    public partial class Listado_Clientes : System.Web.UI.Page
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
            GvUsuarios.DataSource = Mostrar.ListaCliente();
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
            int ClienteID = int.Parse(hdClientesID.Value);
            string Email = txtEmail.Text;
            string Clave = txtContra.Text;
            string Documento = txtDocumento.Text;
            string Nombre = txtNombre.Text;
            string Direccion = txtDireccion.Text;

            int Registro = ModificarCliente.ModificarClientes(ClienteID, Documento, Email, Nombre, Direccion, Clave);

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

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            OcultarDiv();
        }

        public void Limpiar()
        {
            txtEmail.Text = string.Empty;
            txtContra.Text = string.Empty;
            txtDocumento.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
           
        }
        private void Campos()
        {
            string Documento = hdDocumento.Value;
            personas personas = ModificarCliente.BuscarDocumento(Documento);
            hdClientesID.Value = personas.PersonaID.ToString();
            txtEmail.Text = personas.Correo;
            txtContra.Text = personas.Contraseña;
            txtDocumento.Text = personas.Documento;
            txtNombre.Text = personas.Nombre;
            txtDireccion.Text = personas.Direccion;

            Modificar.Visible = true;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int eliminar = int.Parse(hdClientesID.Value);
            bool resultado = Eliminar_Cliente.EliminarCliente(eliminar);

            if(resultado == true)
            {
                Response.Write("<script>alert('Registro Eliminado')</script>");
            }
            else
            {
                Response.Write("<script>alert('Ocurrio Un Erro Al Eliminar')</script>");
            }
        }
    }
}