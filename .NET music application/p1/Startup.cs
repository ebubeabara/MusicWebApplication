using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(p1.Startup))]
namespace p1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
