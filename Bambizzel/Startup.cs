using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bambizzel.Startup))]
namespace Bambizzel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
