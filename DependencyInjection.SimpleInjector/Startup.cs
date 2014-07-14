using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DependencyInjection.SimpleInjector.Startup))]
namespace DependencyInjection.SimpleInjector
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
