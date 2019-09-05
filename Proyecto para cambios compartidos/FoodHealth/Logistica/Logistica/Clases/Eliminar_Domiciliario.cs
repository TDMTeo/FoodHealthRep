using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clases
{
    public class Eliminar_Domiciliario
    {
        public static bool EliminarDomiciliario(int DomiciliarioID)
        {
            DatosDataContext entity = new DatosDataContext();
            bool resultado = true;

            Domiciliario domiciliario = entity.Domiciliario.Where(p => p.DomiciliarioID == DomiciliarioID).Select(p => p).First();
            try
            {
                entity.Domiciliario.DeleteOnSubmit(domiciliario);
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
