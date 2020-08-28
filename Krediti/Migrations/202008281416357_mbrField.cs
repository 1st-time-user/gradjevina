namespace Krediti.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mbrField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aktivnostis", "MBR", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Aktivnostis", "MBR");
        }
    }
}
