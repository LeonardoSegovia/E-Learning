namespace Persistence.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class release_v10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Slug = c.String(),
                        Icon = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Slug = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Image1 = c.String(),
                        Image2 = c.String(),
                        Status = c.Int(nullable: false),
                        Vote = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CatagoryId = c.Int(nullable: false),
                        AuthorId = c.String(maxLength: 128),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AuthorId)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .Index(t => t.AuthorId)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.LeassonsPerCourses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Content = c.String(),
                        Video = c.String(),
                        CourseId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.CourseId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.CourseLeassonLearnedsPerUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LeassonId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LeassonsPerCourses", t => t.LeassonId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.LeassonId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Incomes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EntityType = c.Int(nullable: false),
                        EntityId = c.Int(nullable: false),
                        IncomeType = c.Int(nullable: false),
                        Todal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReviewsPerCouses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Vote = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Commnet = c.String(),
                        CourseId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.CourseId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UsersPerCouses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Completed = c.Boolean(nullable: false),
                        CourseId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.CourseId)
                .Index(t => t.UserId);
            
            AddColumn("dbo.AspNetUsers", "Name", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Credit", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsersPerCouses", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.UsersPerCouses", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.ReviewsPerCouses", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.ReviewsPerCouses", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.CourseLeassonLearnedsPerUsers", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.CourseLeassonLearnedsPerUsers", "LeassonId", "dbo.LeassonsPerCourses");
            DropForeignKey("dbo.LeassonsPerCourses", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.LeassonsPerCourses", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Courses", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Courses", "AuthorId", "dbo.AspNetUsers");
            DropIndex("dbo.UsersPerCouses", new[] { "UserId" });
            DropIndex("dbo.UsersPerCouses", new[] { "CourseId" });
            DropIndex("dbo.ReviewsPerCouses", new[] { "UserId" });
            DropIndex("dbo.ReviewsPerCouses", new[] { "CourseId" });
            DropIndex("dbo.CourseLeassonLearnedsPerUsers", new[] { "UserId" });
            DropIndex("dbo.CourseLeassonLearnedsPerUsers", new[] { "LeassonId" });
            DropIndex("dbo.LeassonsPerCourses", new[] { "UserId" });
            DropIndex("dbo.LeassonsPerCourses", new[] { "CourseId" });
            DropIndex("dbo.Courses", new[] { "Category_Id" });
            DropIndex("dbo.Courses", new[] { "AuthorId" });
            DropColumn("dbo.AspNetUsers", "Credit");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "Name");
            DropTable("dbo.UsersPerCouses");
            DropTable("dbo.ReviewsPerCouses");
            DropTable("dbo.Incomes");
            DropTable("dbo.CourseLeassonLearnedsPerUsers");
            DropTable("dbo.LeassonsPerCourses");
            DropTable("dbo.Courses");
            DropTable("dbo.Categories");
        }
    }
}
