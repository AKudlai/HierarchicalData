namespace HierarchicalData.WebUI.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    using Hierarchical.Contracts;

    using HierarchicalData.Domain;
    using HierarchicalData.WebUI.Models;

    public class FoldersController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        private FolderViewModel folderView;

        public FoldersController(IUnitOfWork unitOfWork, FolderViewModel folderView)
        {
            this.unitOfWork = unitOfWork;
            this.folderView = folderView;
        }

        // GET: Tree
        public ActionResult Index(int id = 1)
        {
            IEnumerable<Folder> folders = this.unitOfWork.Folders.Find(f => true, f => f.Children);
            this.folderView.CurrentFolder = folders.Where(f => f.Id == id).Select(f => f.Name).FirstOrDefault();
            this.folderView.Children = folders.Where(f => f.ParentId == id);
            return this.View(this.folderView);
        }
    }
}