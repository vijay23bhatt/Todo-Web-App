using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(To_DoApp.Startup))]
namespace To_DoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
