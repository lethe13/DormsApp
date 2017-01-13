using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DormsApp.Startup))]
namespace DormsApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
