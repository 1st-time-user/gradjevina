namespace Krediti.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kreditiModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aktivnostis", "MBRID", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Aktivnostis", "MBRID");
        }
    }
}
