namespace HierarchicalData.WebUI
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: null,
                url: "{*url}",
                defaults: new { controller = "Folders", action = "Index" });
        }
    }
}
