using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eRAMO.Administrator.Startup))]
namespace eRAMO.Administrator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
