using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DependencyInjection.AutoFac.Startup))]
namespace DependencyInjection.AutoFac
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
