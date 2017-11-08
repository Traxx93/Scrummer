using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Scrumer.MapperConfig;
using Scrumer.Infrastrucutre.Database;
using Scrumer.Infrastrucutre.Context;

namespace Scrumer
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ScrumerInitializationHandler.Initialize();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var mapper = MapperProvider.Initialize().CreateMapper();

            // Dependency injection:
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // Register types:
            builder.RegisterType<ScrumerContext>()
                   .AsSelf()
                   .InstancePerLifetimeScope();

            builder.RegisterInstance(mapper);

            var container = builder.Build();

            // Register resolver for asp.net mvc:
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
