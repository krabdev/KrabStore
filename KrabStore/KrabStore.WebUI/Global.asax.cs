﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using KrabStore.WebUI.Infrastructure;
using KrabStore.Domain.Entities;
using KrabStore.WebUI.Binders;

namespace KrabStore.WebUI
{
   
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ControllerBuilder.Current.SetControllerFactory(new
                NinjectControllerFactory());
            ModelBinders.Binders.Add(typeof(Cart), new CartModelBinder());
        }
    }
}