using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
   public class Registrar_Cliente
    {
        public static Cliente BuscarCliente(string Doc)
        {
            DatosDataContext context = new DatosDataContext();
            Cliente cliente = null;
            var query = context.Cliente.Where(u => u.Documento == Doc).Select(u => u);

            if (query.Count() > 0)
            {
                cliente = query.First();
            }
            return cliente;
        }

        public static int RegistrarCliente(string Documento, string Correo, string Nombre, string Direccion, string contraseña, int Rol)
        {
            int resultado = 0;

            DatosDataContext Entity = new DatosDataContext();
            Cliente cliente = BuscarCliente(Documento);

            if (cliente == null)
            {
                cliente = new Cliente();
                cliente.Documento = Documento;
                cliente.Correo = Correo;
                cliente.Nombre = Nombre;
                cliente.Direccion = Direccion;
                cliente.Contraseña = contraseña;
                cliente.RolID = Rol;


                try
                {
                    Entity.Cliente.InsertOnSubmit(cliente);
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
