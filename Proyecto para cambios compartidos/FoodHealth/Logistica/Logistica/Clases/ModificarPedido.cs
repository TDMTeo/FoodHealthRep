using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ModificarPedido
    {
        public static int ModificarClientes(int PedidosID, string Cliente, string Domi, string Direccion,
          string Descripcion)
        {
            int resultado = 0;

            DatosDataContext entity = new DatosDataContext();

            Pedido Pedido = entity.Pedido.Where(p => p.PedidoID == PedidosID).Select(p => p).First();
            Pedido.Cliente = Cliente;
            Pedido.Domiciliario = Domi;
            Pedido.Direccion = Direccion;
            Pedido.Descripcion = Descripcion;

            try
            {
                entity.SubmitChanges();

                resultado = 3;
                //Exitoooo
            }
            catch (Exception)
            {
                resultado = 2;
                //Error al modificar
            }

            return resultado;
        }

        public static Pedido BuscarNombreCliente(string Cliente)
        {
            DatosDataContext context = new DatosDataContext();
            Pedido Pedido = null;

            var query = context.Pedido.Where(p => p.Cliente == Cliente).Select(p => p);

            if (query.Count() > 0)
            {
                Pedido = query.First();
            }
            return Pedido;
        }
    }
}
