namespace TheBestWebPage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class readdedFK : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PostModels", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.PostModels", "UserId");
            AddForeignKey("dbo.PostModels", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PostModels", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.PostModels", new[] { "UserId" });
            AlterColumn("dbo.PostModels", "UserId", c => c.String());
        }
    }
}
