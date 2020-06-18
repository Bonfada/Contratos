using Autofac;
using Autofac.Integration.Mvc;
using Contratos.Ioc;
using System.Web.Mvc;

namespace Contratos.App.App_Start
{
    public static class IocConfiguration
    {
        public static void ConfigureDependencyInjection()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            BootStrapper.RegisterServices(builder);

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}