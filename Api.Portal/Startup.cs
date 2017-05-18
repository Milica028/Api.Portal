using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using Owin;
using Microsoft.Owin;
using Portal.DependencyInjection;

[assembly: OwinStartup(typeof(Api.Portal.Startup))]
namespace Api.Portal
{
    public class Startup
    {
        /// <summary>
        /// Konfiguracija Startup klase
        /// </summary>
        /// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            var container = ConfigureInversionOfControl(app, config);
            app.UseAutofacMiddleware(container);
            app.UseAutofacWebApi(config);
            app.UseWebApi(config);
        }

        /// <summary>
        /// Konfiguracija Autofac DI/IoC
        /// </summary>
        /// <param name="app"></param>
        /// <param name="config"></param>
        private IContainer ConfigureInversionOfControl(IAppBuilder app, HttpConfiguration config)
        {

            // Create our container
            var builder = new ContainerBuilder();

            // Register controllers all at once using assembly scanning
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            // Register module
            builder.RegisterModule(new AutofacConfig());

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            // Return our container
            return container;
        }
    }
}