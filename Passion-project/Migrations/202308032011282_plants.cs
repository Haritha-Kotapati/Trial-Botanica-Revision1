namespace Passion_project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class plants : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Plants",
                c => new
                    {
                        Plant_Id = c.Int(nullable: false, identity: true),
                        Plant_Name = c.String(),
                        Plant_Type = c.String(),
                        Plant_Image = c.String(),
                    })
                .PrimaryKey(t => t.Plant_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Plants");
        }
    }
}
