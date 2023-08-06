using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_5032.Startup))]
namespace _5032
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
