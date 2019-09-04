using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
  public class Iniciar_Sesion
    {
        public static int IniciarSesion(String user, String pass)
        {
            DatosDataContext Conexion = new DatosDataContext();
            int Rol = 0;
            var query1 = from p in Conexion.personas
                         where p.Correo == user && p.Contraseña == pass
                         select p;

            if (query1.Count() > 0)
            {
                Rol = query1.First().RolID;
            }

            return Rol;
        }
    }
}
