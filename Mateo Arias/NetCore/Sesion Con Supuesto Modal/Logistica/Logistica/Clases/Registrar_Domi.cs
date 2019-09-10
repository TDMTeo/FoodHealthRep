using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
   public class Registrar_Domi
    {
        public static Domiciliario BuscarDomi(string Documento)
        {
            DatosDataContext context = new DatosDataContext();
            Domiciliario Domi = null;
            var query = context.Domiciliario.Where(u => u.Documento == Documento).Select(u => u);

            if (query.Count() > 0)
            {
                Domi = query.First();
            }
            return Domi;
        }

        public static int RegistrarDomi(string Documento, string Correo, string Nombre, string Contraseña, int Rol)
        {
            int resultado = 0;

            DatosDataContext Entity = new DatosDataContext();
            Domiciliario domicilario = BuscarDomi(Documento);

            if (domicilario == null)
            {
                domicilario = new Domiciliario();
                domicilario.Documento = Documento;
                domicilario.Nombre = Nombre;
                domicilario.Correo = Correo;
                domicilario.Contraseña = Contraseña;
                domicilario.RolID = Rol;

                try
                {
                    Entity.Domiciliario.InsertOnSubmit(domicilario);
                    Entity.SubmitChanges();
                    resultado = 3;
                }
                catch (Exception)
                {
                    resultado = 2;
                }

            }
            else
            {
                resultado = 1;
            }

            return resultado;
        }
    }
}
