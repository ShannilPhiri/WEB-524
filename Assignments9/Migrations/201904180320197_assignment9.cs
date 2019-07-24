namespace Assignments9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class assignment9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tracks", "ContentType", c => c.String(maxLength: 100));
            AddColumn("dbo.Tracks", "Content", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tracks", "Content");
            DropColumn("dbo.Tracks", "ContentType");
        }
    }
}
