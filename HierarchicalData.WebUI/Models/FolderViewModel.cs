namespace HierarchicalData.WebUI.Models
{
    using System.Collections.Generic;

    using HierarchicalData.Domain;

    public class FolderViewModel
    {
        public string CurrentFolder { get; set; }

        public IEnumerable<Folder> Children { get; set; }

        public string Url { get; set; }
    }
}