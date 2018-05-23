namespace HierarchicalData.DAL
{
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Infrastructure;

    using HierarchicalData.Domain;

    public class HierarchicalDataContext : DbContext
    {
        public HierarchicalDataContext()
        {
            // Turn of lazy loading and proxy classes
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;

            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Folder> Folders { get; set; }
    }
}
