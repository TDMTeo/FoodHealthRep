using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Incio
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
            public static int IniciarSesion(String Nombre, String Contraseña)
            {
                Conexion1DataContext Conexion = new Conexion1DataContext();
                int UserID = 0;
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


        protected void Button1_Click(object sender, EventArgs e)
        {
            String Nombre = txtNombre.Text;
            String Pass = txtContra.Text;

            int UserID = ClassLibrary.IniciarSesion(Usuario.Pass);
        }
    }
}