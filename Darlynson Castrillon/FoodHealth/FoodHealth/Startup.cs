using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodHealth.Startup))]
namespace FoodHealth
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
