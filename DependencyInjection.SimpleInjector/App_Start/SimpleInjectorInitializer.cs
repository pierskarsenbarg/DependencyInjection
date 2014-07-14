using DependencyInjection.Common.Classes;
using DependencyInjection.Common.Interfaces;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;

[assembly: WebActivator.PostApplicationStartMethod(typeof(DependencyInjection.SimpleInjector.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace DependencyInjection.SimpleInjector.App_Start
{
    using System.Reflection;
    using System.Web.Mvc;



    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            // Did you know the container can diagnose your configuration? Go to: https://bit.ly/YE8OJj.
            var container = new Container();

            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }

        private static void InitializeContainer(Container container)
        {
            container.Register<IOutput, Class2>();
        }
    }
}