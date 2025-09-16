namespace Camper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CamperLogsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CamperLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CamperId = c.Int(nullable: false),
                        LogDate = c.DateTime(nullable: false),
                        Incident = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Campers", t => t.CamperId, cascadeDelete: true)
                .Index(t => t.CamperId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CamperLogs", "CamperId", "dbo.Campers");
            DropIndex("dbo.CamperLogs", new[] { "CamperId" });
            DropTable("dbo.CamperLogs");
        }
    }
}
