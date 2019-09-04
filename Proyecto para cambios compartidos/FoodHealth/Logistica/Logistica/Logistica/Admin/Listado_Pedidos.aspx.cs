using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace Logistica.Admin
{
    public partial class Listado_Pedidos : System.Web.UI.Page
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
            GvUsuarios.DataSource = Mostrar.ListaPedidos();
            GvUsuarios.DataBind();
        }

        protected void GvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow fila = GvUsuarios.SelectedRow;
            hdClientes.Value = fila.Cells[1].Text;
            Campos();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            int PedidoID = int.Parse(hdPedidoID.Value);
            string Cliente = txtCliente.Text;
            string Domi = txtDomi.Text;
            string Direccion = txtDireccion.Text;
            string Descripcion = txtDescripcion.Text;

            int Registro = ModificarPedido.ModificarClientes(PedidoID, Cliente, Domi, Direccion, Descripcion);

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
            txtCliente.Text = string.Empty;
            txtDomi.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtDescripcion.Text = string.Empty;

        }
        private void Campos()
        {
            string Cliente = hdClientes.Value;
            Pedido Pedido = ModificarPedido.BuscarNombreCliente(Cliente);
            hdPedidoID.Value = Pedido.PedidoID.ToString();
            txtCliente.Text = Pedido.Cliente;
            txtDomi.Text = Pedido.Domiciliario;
            txtDireccion.Text = Pedido.Direccion;
            txtDescripcion.Text = Pedido.Descripcion;

            Modificar.Visible = true;
        }
    }
}