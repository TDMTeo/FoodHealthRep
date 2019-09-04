using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ModificarDomiciliario
    {
        public static int RegistrarDomi(int DomiciliarioID, string Documento, string Correo, string Nombre, string Contraseña)
        {
            int resultado = 0;

            DatosDataContext entity = new DatosDataContext();

            Domiciliario domiciliario = entity.Domiciliario.Where(p => p.DomiciliarioID == DomiciliarioID).Select(p => p).First();
            domiciliario.Documento = Documento;
            domiciliario.Correo = Correo;
            domiciliario.Nombre = Nombre;
            domiciliario.Contraseña = Contraseña;

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
        public static Domiciliario BuscarPorCedula(string Doc)
        {
            DatosDataContext context = new DatosDataContext();
            Domiciliario domiciliario = null;
            var query = context.Domiciliario.Where(u => u.Documento == Doc).Select(u => u);

            if (query.Count() > 0)
            {
                domiciliario = query.First();
            }
            return domiciliario;
        }
    }
}
