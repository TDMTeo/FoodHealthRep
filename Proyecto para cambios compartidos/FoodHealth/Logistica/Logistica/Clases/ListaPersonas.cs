using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
   public class ListaPersonas
    {
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

    }
}
