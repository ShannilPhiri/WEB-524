namespace Assignments9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "Depiction", c => c.String());
            AddColumn("dbo.Artists", "Portrayl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Artists", "Portrayl");
            DropColumn("dbo.Albums", "Depiction");
        }
    }
}
