using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Principal;

namespace Iniciar
{
    public class Modelo
    {
        public static int IniciarSesion(String user, String pass)
        {
            Datos1DataContext Conexion = new Datos1DataContext();
            int UserID = 0;
            var query1 = from p in Conexion.personas
                         where p.Nombre == user && p.Documento == pass 
                         select p;

            if (query1.Count() > 0)
            {
                UserID = query1.First().PersonaID;
            }
            return UserID;
        }
    }
}