using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace currencyConverter
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

            config.Routes.MapHttpRoute(
                name: "ConverterApi",
                routeTemplate: "api/{controller}/{currencyFrom}/{currencyTo}/{amount}",
                defaults: new { currencyFrom = RouteParameter.Optional, currencyTo = RouteParameter.Optional, amount = RouteParameter.Optional }
                );
        }
    }
}
