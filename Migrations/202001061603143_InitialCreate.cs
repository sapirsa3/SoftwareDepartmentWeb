namespace projectnetwork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.user1",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Permmision = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.user1");
        }
    }
}
