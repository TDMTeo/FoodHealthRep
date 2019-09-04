using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
   public class Agregar_Pedido
    {
        public static Cliente BuscarNombreCliente(string name)
        {
            DatosDataContext context = new DatosDataContext();
            Cliente Cliente = null;
            var query = context.Cliente.Where(u => u.Nombre == name).Select(u => u);

            if (query.Count() > 0)
            {
                Cliente = query.First();
            }
            return Cliente;
        }

        public static int RegistrarPedido(string Cliente, string Domi, string Direccion, string Descripcion)
        {
            int resultado = 0;

            DatosDataContext Entity = new DatosDataContext();
            Cliente persona = BuscarNombreCliente(Cliente);

            Pedido pedido = new Pedido();

            if (persona == null)
            {
                resultado = 1;
            }
            else
            {
                pedido.Cliente = Cliente;
                pedido.Domiciliario = Domi;
                pedido.Direccion = Direccion;
                pedido.Descripcion = Descripcion;

                try
                {
                    Entity.Pedido.InsertOnSubmit(pedido);
                    Entity.SubmitChanges();
                    resultado = 3;
                }
                catch (Exception)
                {
                    resultado = 2;
                }
            }

            return resultado;
        }
    }
}
