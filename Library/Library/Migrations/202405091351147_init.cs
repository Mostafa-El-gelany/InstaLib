namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ISBN = c.Long(nullable: false),
                        Title = c.String(),
                        author = c.String(),
                        Publisher = c.String(),
                        quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ISBN);
            
            CreateTable(
                "dbo.UserBooks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        BookId = c.Long(nullable: false),
                        DateOfBorrowing = c.DateTime(nullable: false),
                        IsReturned = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                        rule = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserBooks", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserBooks", "BookId", "dbo.Books");
            DropIndex("dbo.UserBooks", new[] { "BookId" });
            DropIndex("dbo.UserBooks", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.UserBooks");
            DropTable("dbo.Books");
        }
    }
}
