namespace HierarchicalData.WebUI.Infrastructure
{
    using Hierarchical.Contracts;
    using Hierarchical.Services.Repositories;

    using Ninject.Modules;

    public class NinjectRegistrations : NinjectModule

    {
        public override void Load()
        {
            this.Kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            this.Kernel.Bind(typeof(IGenericRepository<>)).To(typeof(GenericRepository<>));
        }
    }
}