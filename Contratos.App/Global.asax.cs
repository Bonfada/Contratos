using Contratos.App.App_Start;
using Contratos.App.AutoMapper;
using Contratos.Services.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Contratos.App
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            AutoMapperMVCConfig.RegisterMappings();
            AutoMapperBusinessConfig.RegisterMappings();

            IocConfiguration.ConfigureDependencyInjection();
        }
    }
}
