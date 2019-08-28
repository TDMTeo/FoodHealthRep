using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logistica
{
    public class Registrar
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

        public static int RegistrarUsuario(string Documento, string Correo, string Nombre, string Direccion)
        {
            int resultado = 0;

            DatosDataContext Entity = new DatosDataContext();
            personas persona = BuscarPorCedula(Documento);

            if (persona == null)
            {
                persona = new personas();
                persona.Documento = Documento;
                persona.Nombre = Nombre;
                persona.Correo = Correo;
                persona.Direccion = Direccion;
                persona.RolID = 1;

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