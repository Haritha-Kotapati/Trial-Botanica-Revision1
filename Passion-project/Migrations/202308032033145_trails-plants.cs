namespace Passion_project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class trailsplants : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlantTrails",
                c => new
                    {
                        Plant_Plant_Id = c.Int(nullable: false),
                        Trail_TrailID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Plant_Plant_Id, t.Trail_TrailID })
                .ForeignKey("dbo.Plants", t => t.Plant_Plant_Id, cascadeDelete: true)
                .ForeignKey("dbo.Trails", t => t.Trail_TrailID, cascadeDelete: true)
                .Index(t => t.Plant_Plant_Id)
                .Index(t => t.Trail_TrailID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlantTrails", "Trail_TrailID", "dbo.Trails");
            DropForeignKey("dbo.PlantTrails", "Plant_Plant_Id", "dbo.Plants");
            DropIndex("dbo.PlantTrails", new[] { "Trail_TrailID" });
            DropIndex("dbo.PlantTrails", new[] { "Plant_Plant_Id" });
            DropTable("dbo.PlantTrails");
        }
    }
}
