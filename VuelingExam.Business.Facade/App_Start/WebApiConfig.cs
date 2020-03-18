using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using VuelingExam.Business.Filters.Framework;

namespace VuelingExam.Business.Facade
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Filters.Add(new NotImplementedExceptionFilterAttribute());
            config.Filters.Add(new NullReferenceExceptionFilterAttribute());
            config.Filters.Add(new IOExceptionFilterAttribute());
            config.Filters.Add(new UnauthorizedAccessExceptionFilterAttribute());
            config.Filters.Add(new PathTooLongExceptionFilterAttribute());
        }
    }
}
