﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using Lightning_Rewards.Models;
using Microsoft.Practices.Unity;
using Lightning_Rewards.Managers;

namespace Lightning_Rewards
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
            // Web API configuration and services
            var container = new UnityContainer();
            container.RegisterType<IUserManager, UserManager>(new HierarchicalLifetimeManager());
            container.RegisterType<IDashboardManager, DashboardManager>(new HierarchicalLifetimeManager());
            container.RegisterType<ICardManager, CardManager>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
