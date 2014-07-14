using DependencyInjection.Common.Classes;
using DependencyInjection.Common.Interfaces;
using Ninject.Modules;

namespace DependencyInjection.Ninject
{
    public class CoreModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IOutput>().To<Class2>();
        }
    }
}