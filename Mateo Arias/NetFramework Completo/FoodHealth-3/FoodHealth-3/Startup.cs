using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodHealth_3.Startup))]
namespace FoodHealth_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
