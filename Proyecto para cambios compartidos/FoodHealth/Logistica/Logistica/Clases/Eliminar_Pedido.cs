using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clases
{
    public class Eliminar_Pedido
    {
        public static bool EliminarPedido(int PedidoID)
        {
            DatosDataContext entity = new DatosDataContext();
            bool resultado = true;

            Pedido pedido = entity.Pedido.Where(p => p.PedidoID == PedidoID).Select(p => p).First();
            try
            {
                entity.Pedido.DeleteOnSubmit(pedido);
                entity.SubmitChanges();
            }
            catch (Exception)
            {
                resultado = false;
            }

            return resultado;
        }
    }
}
