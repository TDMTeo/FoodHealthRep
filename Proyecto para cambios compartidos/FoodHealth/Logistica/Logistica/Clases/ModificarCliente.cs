using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ModificarCliente
    {
        public static int ModificarClientes(int PersonaID, string Documento, string Correo, string Nombre,
            string Direccion, string Contraseña)
        {
            int resultado = 0;

            DatosDataContext entity = new DatosDataContext();

            personas personas = entity.personas.Where(p => p.PersonaID == PersonaID).Select(p => p).First();
            personas.Documento = Documento;
            personas.Correo = Correo;
            personas.Nombre = Nombre;
            personas.Direccion = Direccion;
            personas.Contraseña = Contraseña;

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

        public static personas BuscarDocumento(string documentos)
        {
            DatosDataContext context = new DatosDataContext();
            personas empleados = null;

            var query = context.personas.Where(p => p.Documento == documentos).Select(p => p);

            if (query.Count() > 0)
            {
                empleados = query.First();
            }
            return empleados;
        }

    }
}
