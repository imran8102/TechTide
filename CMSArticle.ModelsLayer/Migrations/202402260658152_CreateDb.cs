namespace CMSArticle.ModelsLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.T_Admin",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                        Family = c.String(nullable: false, maxLength: 30),
                        PhoneNumber = c.String(nullable: false, maxLength: 13),
                        Password = c.String(nullable: false),
                        RegisterDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.T_Article",
                c => new
                    {
                        ArticleId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Content = c.String(nullable: false),
                        ImageName = c.String(),
                        Like = c.Int(nullable: false),
                        Visit = c.Int(nullable: false),
                        RegisterDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        AdminId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArticleId)
                .ForeignKey("dbo.T_Admin", t => t.AdminId, cascadeDelete: true)
                .ForeignKey("dbo.T_Category", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.AdminId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.T_Category",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 30),
                        ImageName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.T_Comment",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false),
                        Content = c.String(nullable: false, maxLength: 150),
                        RegisterDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Article_ArticleId = c.Int(),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.T_Article", t => t.Article_ArticleId)
                .Index(t => t.Article_ArticleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.T_Comment", "Article_ArticleId", "dbo.T_Article");
            DropForeignKey("dbo.T_Article", "CategoryId", "dbo.T_Category");
            DropForeignKey("dbo.T_Article", "AdminId", "dbo.T_Admin");
            DropIndex("dbo.T_Comment", new[] { "Article_ArticleId" });
            DropIndex("dbo.T_Article", new[] { "CategoryId" });
            DropIndex("dbo.T_Article", new[] { "AdminId" });
            DropTable("dbo.T_Comment");
            DropTable("dbo.T_Category");
            DropTable("dbo.T_Article");
            DropTable("dbo.T_Admin");
        }
    }
}
