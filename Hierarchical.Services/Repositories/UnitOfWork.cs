namespace Hierarchical.Services.Repositories
{
    using System;
    using System.Data.Entity;

    using Hierarchical.Contracts;

    using HierarchicalData.DAL;
    using HierarchicalData.Domain;

    public class UnitOfWork : IUnitOfWork
    {
        private DbContext context;

        private IGenericRepository<Folder> foldersRepository;

        private bool disposed = false;

        public UnitOfWork()
        {
            this.context = new HierarchicalDataContext();
        }

        public IGenericRepository<Folder> Folders => this.foldersRepository ?? (this.foldersRepository = new GenericRepository<Folder>(this.context));

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.context.Dispose();
                }

                this.disposed = true;
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
