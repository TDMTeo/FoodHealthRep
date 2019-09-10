using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Iniciar
{
    public class Mostrar
    {
        public static personas BuscarporID(int UserID)
        {
            Datos1DataContext Conexion = new Datos1DataContext();
            personas Personas = null;


            var query = Conexion.personas.Where(p => p.PersonaID == UserID).Select(p => p);

            if (query.Count() > 0)
            {
                Personas = query.First();
            }
            return Personas;
        }

        public static Object ListaPersona()
        {
            Datos1DataContext Conexion = new Datos1DataContext();
            var query = from u in Conexion.personas
                        select new
                        {
                            Documento = u.Documento,
                            Nombre = u.Nombre,
                            Correo = u.Correo,
                            Direccion = u.Direccion
                        };

            return query;


        }

    }
}