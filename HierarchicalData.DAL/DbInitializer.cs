namespace HierarchicalData.DAL
{
    using System.Collections.Generic;
    using System.Data.Entity;

    using HierarchicalData.Domain;

    public class DbInitializer : DropCreateDatabaseAlways<HierarchicalDataContext>
    {
        protected override void Seed(HierarchicalDataContext context)
        {
            context.Folders.Add(
                new Folder
                    {
                        Name = "Creating Digital Images",
                        URL = "Creating Digital Images/",
                    Children = new List<Folder>
                                       {
                                           new Folder
                                               {
                                                   Name = "Resources",
                                                   URL = "Creating Digital Images/Resources/",
                                                   Children =
                                                       new List<Folder>
                                                           {
                                                               new Folder
                                                                   {
                                                                       Name = "Primary Sources",
                                                                       URL = "Creating Digital Images/Resources/Primary Sources/",
                                                                       Children = new List<Folder>
                                                                                      {
                                                                                          new Folder
                                                                                              {
                                                                                                  Name = "Source 1",
                                                                                                  URL = "Creating Digital Images/Resources/Primary Sources/Source 1/"
                                                                                              }
                                                                                      }
                                                                   },
                                                               new Folder
                                                                   {
                                                                       Name
                                                                           = "Secondary Sources",
                                                                       URL = "Creating Digital Images/Resources/Secondary Sources/",
                                                                   }
                                                           }
                                               },
                                           new Folder { Name = "Evidence", URL = "Creating Digital Images/Evidence/",  },
                                           new Folder
                                               {
                                                   Name = "Graphic Products",
                                                   URL = "Creating Digital Images/Graphic Products/",
                                                   Children =
                                                       new List<Folder>
                                                           {
                                                               new Folder
                                                                   {
                                                                       Name
                                                                           = "Process",
                                                                       URL = "Creating Digital Images/Graphic Products/Process/",
                                                                   },
                                                               new Folder
                                                                   {
                                                                       Name
                                                                           = "Final Product",
                                                                       URL = "Creating Digital Images/Graphic Products/Final Product/"
                                                                   }
                                                           }
                                               }
                                       }
                    });
            base.Seed(context);
        }
    }
}