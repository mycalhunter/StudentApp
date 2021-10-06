using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace First
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Routes are handled one after another, if one does not fit - then it will move to the next to evaluate the request
            routes.MapRoute(
                name: "Student",
                url: "students/{id}/{name}/{standardId}",
                defaults: new { controller = "Student", action = "Index", id = UrlParameter.Optional, name = UrlParameter.Optional, standardId = UrlParameter.Optional },
                constraints: new { id = @"\d+" } // Constraint that requires ID to be numeric, non-numeric value will then be handled be a different route or if no matching routes exist -- then "The resource could not be found" error will be thrown
            ); 
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
