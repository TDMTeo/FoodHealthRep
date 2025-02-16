﻿using System;
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
