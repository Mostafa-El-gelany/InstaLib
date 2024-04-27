namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserBook : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserBooks",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        BookId = c.Int(nullable: false),
                        DateOfBorrowing = c.DateTime(nullable: false),
                        IsReturned = c.Boolean(nullable: false),
                        User_Username = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.BookId })
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Username)
                .Index(t => t.BookId)
                .Index(t => t.User_Username);
            
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
            DropForeignKey("dbo.UserBooks", "User_Username", "dbo.Users");
            DropForeignKey("dbo.UserBooks", "BookId", "dbo.Books");
            DropIndex("dbo.UserBooks", new[] { "User_Username" });
            DropIndex("dbo.UserBooks", new[] { "BookId" });
            DropTable("dbo.Users");
            DropTable("dbo.UserBooks");
        }
    }
}
