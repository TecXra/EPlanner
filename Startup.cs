using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EPlanner.Startup))]
namespace EPlanner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
