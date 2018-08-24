﻿using DG.API.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DG.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            UnityConfig.Register(config);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "actionApi",
                routeTemplate: "api/{controller}/{action}/{code}",
                defaults: new { code = RouteParameter.Optional }
            );
        }
    }
}