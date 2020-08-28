namespace Krediti.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aktivnostiNovopitanje : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aktivnostis", "Pitanje7", c => c.String());
            AlterColumn("dbo.Aktivnostis", "Pitanje3", c => c.String());
            AlterColumn("dbo.Aktivnostis", "Pitanje4", c => c.Int());
            AlterColumn("dbo.Aktivnostis", "Pitanje5", c => c.String());
            AlterColumn("dbo.Aktivnostis", "Pitanje6", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Aktivnostis", "Pitanje6", c => c.String());
            AlterColumn("dbo.Aktivnostis", "Pitanje5", c => c.Int());
            AlterColumn("dbo.Aktivnostis", "Pitanje4", c => c.String());
            AlterColumn("dbo.Aktivnostis", "Pitanje3", c => c.Int());
            DropColumn("dbo.Aktivnostis", "Pitanje7");
        }
    }
}
