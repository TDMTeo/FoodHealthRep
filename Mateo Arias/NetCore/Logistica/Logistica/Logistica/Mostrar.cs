using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logistica
{
    public class Mostrar
    {
        public static personas BuscarporID(int UserID)
        {
            DatosDataContext Conexion = new DatosDataContext();
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
            DatosDataContext Conexion = new DatosDataContext();
            var query = from u in Conexion.Domiciliario
                        select new
                        {
                            Documento = u.Documento,
                            Nombre = u.Nombre,
                            Correo = u.Correo,
                            Contraseña = u.Contraseña
                        };

            return query;
        }

        public static Object ListaCliente()
        {
            DatosDataContext Conexion = new DatosDataContext();
            var query = from u in Conexion.Cliente
                        select new
                        {
                            Documento = u.Documento,
                            Nombre = u.Nombre,
                            Correo = u.Correo,
                            Direccion = u.Direccion
                        };

            return query;
        }

        public static Object ListaDomiciliario()
        {
            DatosDataContext Conexion = new DatosDataContext();
            var query = from u in Conexion.Domiciliario
                        select new
                        {
                            Documento = u.Documento,
                            Nombre = u.Nombre,
                            Correo = u.Correo
                        };

            return query;
        }
    }
}