namespace TheBestWebPage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeFK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PostModels", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.PostModels", new[] { "UserId" });
            AlterColumn("dbo.PostModels", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PostModels", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.PostModels", "UserId");
            AddForeignKey("dbo.PostModels", "UserId", "dbo.AspNetUsers", "Id");
        }
    }
}
