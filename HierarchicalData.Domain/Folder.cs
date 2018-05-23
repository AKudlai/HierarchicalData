namespace HierarchicalData.Domain
{
    using System.Collections.Generic;

    public class Folder
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        public string Name { get; set; }

        public virtual Folder Parent { get; set; }

        public virtual ICollection<Folder> Children { get; set; }
    }
}
