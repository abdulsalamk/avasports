using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AVASports.Startup))]
namespace AVASports
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
