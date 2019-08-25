using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Conexion
{
    public class Class1
    {
        public static int IniciarSesion(String user, String pass)
        {
            
            int UserID = 0;
            var query = context.Usuario.Where(p => p.SysNombre == Nombre && p.SysContraseña == Contraseña).select(p => p);

            if (query.Count() > 0)
            {
                UserID = query.First().IDUser;
            }
            return UserID;
        }
    }
}
