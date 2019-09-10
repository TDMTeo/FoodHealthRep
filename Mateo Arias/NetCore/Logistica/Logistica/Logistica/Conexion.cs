using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logistica
{
    public class Conexion
    {
        public static int IniciarSesion(String user, String pass)
        {
            DatosDataContext Conexion = new DatosDataContext();
            int Rol = 0;
            var query1 = from p in Conexion.personas
                         where p.Nombre == user && p.Contraseña == pass
                         select p;

            if (query1.Count() > 0)
            {
                Rol = query1.First().RolID;
            }

            return Rol;
        }
    }
}