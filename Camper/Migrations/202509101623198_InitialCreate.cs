namespace Camper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Campers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CamperName = c.String(),
                        EmergencyContact = c.String(),
                        MedicalConditions = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Campers");
        }
    }
}
