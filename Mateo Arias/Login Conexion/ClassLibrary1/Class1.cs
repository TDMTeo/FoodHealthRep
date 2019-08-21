using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassLibrary1
{
    public class Class1
    {
        public static int IniciarSesion(String Nombre, String Contraseña)
        {
            Conexion1DataContext Conexion = new Conexion1DataContext();
            int UserID =  0;
            var query = Conexion.Usuario.Where(p => p.Nombre == Nombre && p.Contraseña == Contraseña).Select(p => p);

            var query1 = from p in Conexion.Usuario
                         where p.Nombre == Nombre && p.Contraseña == Contraseña
                         select p;

            if (query.Count() > 0)
            {
                UserID = query.First().UsuarioID;
            }

            return UserID;
        }

    }
}
