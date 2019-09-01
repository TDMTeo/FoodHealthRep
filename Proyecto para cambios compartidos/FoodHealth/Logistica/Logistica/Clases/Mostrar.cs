using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
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
            var query = from u in Conexion.personas
                        select new
                        {
                            Rol = u.RolID,
                            Documento = u.Documento,
                            Nombre = u.Nombre,
                            Correo = u.Correo,
                            Direccion = u.Direccion
                        };

            return query;
        }

        public static Object ListaDomiciliario(string nombre, int Rol)
        {
            DatosDataContext Conexion = new DatosDataContext();
            var query = from u in Conexion.Domiciliario
                        select new
                        {
                            Rol = u.RolID,
                            Documento = u.Documento,
                            Nombre = u.Nombre,
                            Correo = u.Correo
                        };
            return query; 
        }

        public static Object ListaRol()
        {
            DatosDataContext Conexion = new DatosDataContext();
            var query = from u in Conexion.Rol
                        select new
                        {
                            Rol = u.RolID,
                            Nombre = u.NombreRol
                        };
            return query;


        }


    }
}
