using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BibliotecaApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            // Web API configuration and services
            var formatters = GlobalConfiguration.Configuration.Formatters;

            formatters.Remove(formatters.XmlFormatter);

            var json = config.Formatters.JsonFormatter;

            var settings = json.SerializerSettings;
            settings.Formatting = Formatting.Indented;
            settings.ContractResolver = new DefaultContractResolver();

            json.SerializerSettings.Re‌​ferenceLoopHandling = ReferenceLoopHandling.Ignore;



            // Web API configuration and services

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
