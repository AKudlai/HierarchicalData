namespace HierarchicalData.WebUI
{
    using System.Web.Mvc;
    using System.Web.Routing;

    using HierarchicalData.WebUI.Infrastructure;

    using Ninject;
    using Ninject.Modules;
    using Ninject.Web.Mvc;

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Dependency injection
            NinjectModule registrations = new NinjectRegistrations();
            var kernel = new StandardKernel(registrations);
            kernel.Unbind<ModelValidatorProvider>();
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}
