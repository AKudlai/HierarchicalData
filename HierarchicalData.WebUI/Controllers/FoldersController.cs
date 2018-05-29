namespace HierarchicalData.WebUI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    using Hierarchical.Contracts;

    using HierarchicalData.Domain;
    using HierarchicalData.WebUI.Models;

    public class FoldersController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly FolderViewModel folderView;

        public FoldersController(IUnitOfWork unitOfWork, FolderViewModel folderView)
        {
            this.unitOfWork = unitOfWork;
            this.folderView = folderView;
        }

        // GET: Tree
        public ActionResult Index(string url)
        {
            IEnumerable<Folder> folders = this.unitOfWork.Folders.Find(f => true, f => f.Children);             
            this.folderView.CurrentFolder = folders.Where(f => f.URL == url).Select(f => f.Name).FirstOrDefault();
            this.folderView.Children = folders.Where(f => f.Parent != null && f.Parent.URL == url);
            this.folderView.Root = folders.FirstOrDefault(f => f.ParentId == null).URL;
            return this.View(this.folderView);
        }
    }
}