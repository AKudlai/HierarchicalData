namespace HierarchicalData.DAL
{
    using System.Collections.Generic;
    using System.Data.Entity;

    using HierarchicalData.Domain;

    public class DbInitializer : DropCreateDatabaseIfModelChanges<HierarchicalDataContext>
    {
        protected override void Seed(HierarchicalDataContext context)
        {
            context.Folders.Add(
                new Folder
                    {
                        Name = "Creating Digital Images",
                        Children = new List<Folder>
                                       {
                                           new Folder
                                               {
                                                   Name = "Resources",
                                                   Children =
                                                       new List<Folder>
                                                           {
                                                               new Folder
                                                                   {
                                                                       Name
                                                                           = "Primary Sources"
                                                                   },
                                                               new Folder
                                                                   {
                                                                       Name
                                                                           = "Secondary Sources"
                                                                   }
                                                           }
                                               },
                                           new Folder { Name = "Evidence" },
                                           new Folder
                                               {
                                                   Name = "Graphic Products",
                                                   Children =
                                                       new List<Folder>
                                                           {
                                                               new Folder
                                                                   {
                                                                       Name
                                                                           = "Process"
                                                                   },
                                                               new Folder
                                                                   {
                                                                       Name
                                                                           = "Final Product"
                                                                   }
                                                           }
                                               }
                                       }
                    });
            base.Seed(context);
        }
    }
}