using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
   public class Registrar_Usuario
    {
        public static personas BuscarPorCedula(string Doc)
        {
            DatosDataContext context = new DatosDataContext();
            personas persona = null;
            var query = context.personas.Where(u => u.Documento == Doc).Select(u => u);

            if (query.Count() > 0)
            {
                persona = query.First();
            }
            return persona;
        }

        public static int RegistrarUsuario(string Documento, string Correo, string Nombre, string Direccion, string contraseña, int Rol)
        {
            int resultado = 0;

            DatosDataContext Entity = new DatosDataContext();
            personas persona = BuscarPorCedula(Documento);

            if (persona == null)
            {
                persona = new personas();
                persona.Documento = Documento;
                persona.Correo = Correo;
                persona.Nombre = Nombre;
                persona.Direccion = Direccion;
                persona.Contraseña = contraseña;
                persona.RolID = Rol;

                try
                {
                    Entity.personas.InsertOnSubmit(persona);
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
