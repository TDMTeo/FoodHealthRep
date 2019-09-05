using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Mostrar
    {
        
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

        public static Object ListaDomiciliario()
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

        public static Object ListaPedidos()
        {
            DatosDataContext Conexion = new DatosDataContext();
            var query = from u in Conexion.Pedido
                        select new
                        {
                            Cliente = u.Cliente,
                            Domiciliario = u.Domiciliario,
                            Direccion = u.Direccion,
                            Descripcion = u.Descripcion
                        };
               return query;
        }

        public static Object ListaPedidoscliente()
        {
            DatosDataContext Conexion = new DatosDataContext();
            var query = from u in Conexion.Pedido
                        select new
                        {
                            Cliente = u.Cliente,
                            Domiciliario = u.Domiciliario,
                            Descripcion = u.Descripcion
                        };
            return query;
        }


    }
}
