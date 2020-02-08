namespace PWM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Plants",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        LastWatered = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Plants");
        }
    }
}
