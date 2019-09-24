using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppEmpleados.Startup))]
namespace AppEmpleados
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
