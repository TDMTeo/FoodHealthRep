using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Food_Health_Modulo_3__B_4._3_.Startup))]
namespace Food_Health_Modulo_3__B_4._3_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
