using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Initiation
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Frontpage","", new { controller = "Home", action = "Index"});

            routes.MapRoute("Form", "Formulaire", new { controller = "Form", action = "Form" });
        }
    }
}