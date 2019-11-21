using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AirlineMVC.Startup))]
namespace AirlineMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
