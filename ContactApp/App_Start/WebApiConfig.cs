using ContactApp.Controllers;
using ContactLib.DAL;
using ContactPortableLib.DAL;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ContactApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            
            var unity = new UnityContainer();

            unity.RegisterType<ContactController>();
            unity.RegisterType<IContactDAL, ContactDAL>(new HierarchicalLifetimeManager());

            config.DependencyResolver = new UnityResolver(unity);
        }
    }
}
