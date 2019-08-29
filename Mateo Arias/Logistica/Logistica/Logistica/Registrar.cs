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

        public static int RegistrarUsuario(string Documento, string Correo, string Nombre, string Direccion, string contraseña)
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