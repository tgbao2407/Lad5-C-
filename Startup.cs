using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lad5.Startup))]
namespace Lad5
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
