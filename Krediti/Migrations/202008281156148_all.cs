namespace Krediti.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class all : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aktivnostis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Pitanje1 = c.Int(),
                        Pitanje2 = c.Int(),
                        Pitanje3 = c.Int(),
                        Pitanje4 = c.String(),
                        Pitanje5 = c.Int(),
                        Pitanje6 = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MBRDatas",
                c => new
                    {
                        MBRID = c.Int(nullable: false, identity: true),
                        MBR = c.String(),
                        Naziv = c.String(),
                        Naselje = c.String(),
                        Ulica = c.String(),
                    })
                .PrimaryKey(t => t.MBRID);
            
            CreateTable(
                "dbo.Shows",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MBRID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Shows");
            DropTable("dbo.MBRDatas");
            DropTable("dbo.Aktivnostis");
        }
    }
}
