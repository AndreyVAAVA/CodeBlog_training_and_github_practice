namespace CodeBlog_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GC : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GraphicsCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        corp = c.String(),
                        vendor = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GraphicsCards");
        }
    }
}
