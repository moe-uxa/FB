using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eRAMO.FB.Web.Startup))]
namespace eRAMO.FB.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
