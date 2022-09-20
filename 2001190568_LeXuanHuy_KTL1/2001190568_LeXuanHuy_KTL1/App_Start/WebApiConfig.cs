using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace _2001190568_LeXuanHuy_KTL1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
