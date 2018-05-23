namespace Hierarchical.Contracts
{
    using HierarchicalData.Domain;

    public interface IUnitOfWork
    {
        IGenericRepository<Folder> Folders { get; }

        void SaveChanges();

        void Dispose();
    }
}
