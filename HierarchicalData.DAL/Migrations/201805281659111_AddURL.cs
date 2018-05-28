namespace HierarchicalData.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddURL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Folders", "URL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Folders", "URL");
        }
    }
}
