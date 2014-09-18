using ContactApp.Controllers;
using ContactApp.DI;
using ContactLib.DAL;
using ContactLib.EFContext;
using ContactPortableLib.DAL;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ContactApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ContactLib.AutoMapperSetup.AutoMapperSetup.SetupAll();

            //// Create a new Unity dependency injection container
            //var unity = new UnityContainer();

            //// Register the Controllers that should be injectable
            //unity.RegisterType<ContactController>();
            //unity.RegisterType<IContactDAL, ContactDAL>(new HierarchicalLifetimeManager());
            //// Register instances to be used when resolving constructor parameter dependencies
            ////unity.RegisterInstance(typeof(IContactDAL), new ContactDAL());

            //// Finally, override the default dependency resolver with Unity
            //GlobalConfiguration.Configuration.DependencyResolver = new IoCContainer(unity);

        }
    }
}
