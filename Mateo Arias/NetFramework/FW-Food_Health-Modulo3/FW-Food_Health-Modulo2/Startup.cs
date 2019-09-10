using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FW_Food_Health_Modulo2.Startup))]
namespace FW_Food_Health_Modulo2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
