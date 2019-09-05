using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clases
{
    public class Eliminar_Cliente
    {
        public static bool EliminarCliente(int PersonasID)
        {
            DatosDataContext entity = new DatosDataContext();
            bool resultado = true;

            personas persona = entity.personas.Where(p => p.PersonaID == PersonasID).Select(p => p).First();
            try
            {
                entity.personas.DeleteOnSubmit(persona);
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
