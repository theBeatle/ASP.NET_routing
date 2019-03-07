﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DefaultValues
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default", // имя маршрута
                url: "{controller}/{action}", // переменные сегментов
                defaults: new { controller = "Home", action = "Index" } // значения по умолчанию
            );
        }
    }
}