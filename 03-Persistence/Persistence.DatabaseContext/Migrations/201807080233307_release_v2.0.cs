namespace Persistence.DatabaseContext.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class release_v20 : DbMigration
    {
        public override void Up()
        {
            AlterTableAnnotations(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Slug = c.String(),
                        Icon = c.String(),
                        Deleted = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                        DeletedAt = c.DateTime(),
                        DeletedBy = c.String(maxLength: 128),
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "DynamicFilter_Category_IsDeleted",
                        new AnnotationValues(oldValue: null, newValue: "EntityFramework.DynamicFilters.DynamicFilterDefinition")
                    },
                });
            
            AlterTableAnnotations(
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
                        Deleted = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                        DeletedAt = c.DateTime(),
                        DeletedBy = c.String(maxLength: 128),
                        Category_Id = c.Int(),
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "DynamicFilter_Course_IsDeleted",
                        new AnnotationValues(oldValue: null, newValue: "EntityFramework.DynamicFilters.DynamicFilterDefinition")
                    },
                });
            
            AlterTableAnnotations(
                "dbo.CourseLeassonLearnedsPerUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LeassonId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                        Deleted = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                        DeletedAt = c.DateTime(),
                        DeletedBy = c.String(maxLength: 128),
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "DynamicFilter_CourseLeassonLearnedsPerUser_IsDeleted",
                        new AnnotationValues(oldValue: null, newValue: "EntityFramework.DynamicFilters.DynamicFilterDefinition")
                    },
                });
            
            AlterTableAnnotations(
                "dbo.Incomes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EntityType = c.Int(nullable: false),
                        EntityId = c.Int(nullable: false),
                        IncomeType = c.Int(nullable: false),
                        Todal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Deleted = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                        DeletedAt = c.DateTime(),
                        DeletedBy = c.String(maxLength: 128),
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "DynamicFilter_Income_IsDeleted",
                        new AnnotationValues(oldValue: null, newValue: "EntityFramework.DynamicFilters.DynamicFilterDefinition")
                    },
                });
            
            AlterTableAnnotations(
                "dbo.ReviewsPerCouses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Vote = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Commnet = c.String(),
                        CourseId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                        Deleted = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                        DeletedAt = c.DateTime(),
                        DeletedBy = c.String(maxLength: 128),
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "DynamicFilter_ReviewsPerCouse_IsDeleted",
                        new AnnotationValues(oldValue: null, newValue: "EntityFramework.DynamicFilters.DynamicFilterDefinition")
                    },
                });
            
            AlterTableAnnotations(
                "dbo.UsersPerCouses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Completed = c.Boolean(nullable: false),
                        CourseId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                        Deleted = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                        DeletedAt = c.DateTime(),
                        DeletedBy = c.String(maxLength: 128),
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "DynamicFilter_UsersPerCouse_IsDeleted",
                        new AnnotationValues(oldValue: null, newValue: "EntityFramework.DynamicFilters.DynamicFilterDefinition")
                    },
                });
            
            AddColumn("dbo.Categories", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Categories", "CreatedAt", c => c.DateTime());
            AddColumn("dbo.Categories", "CreatedBy", c => c.String(maxLength: 128));
            AddColumn("dbo.Categories", "UpdatedAt", c => c.DateTime());
            AddColumn("dbo.Categories", "UpdatedBy", c => c.String(maxLength: 128));
            AddColumn("dbo.Categories", "DeletedAt", c => c.DateTime());
            AddColumn("dbo.Categories", "DeletedBy", c => c.String(maxLength: 128));
            AddColumn("dbo.Courses", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Courses", "CreatedAt", c => c.DateTime());
            AddColumn("dbo.Courses", "CreatedBy", c => c.String(maxLength: 128));
            AddColumn("dbo.Courses", "UpdatedAt", c => c.DateTime());
            AddColumn("dbo.Courses", "UpdatedBy", c => c.String(maxLength: 128));
            AddColumn("dbo.Courses", "DeletedAt", c => c.DateTime());
            AddColumn("dbo.Courses", "DeletedBy", c => c.String(maxLength: 128));
            AddColumn("dbo.CourseLeassonLearnedsPerUsers", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.CourseLeassonLearnedsPerUsers", "CreatedAt", c => c.DateTime());
            AddColumn("dbo.CourseLeassonLearnedsPerUsers", "CreatedBy", c => c.String(maxLength: 128));
            AddColumn("dbo.CourseLeassonLearnedsPerUsers", "UpdatedAt", c => c.DateTime());
            AddColumn("dbo.CourseLeassonLearnedsPerUsers", "UpdatedBy", c => c.String(maxLength: 128));
            AddColumn("dbo.CourseLeassonLearnedsPerUsers", "DeletedAt", c => c.DateTime());
            AddColumn("dbo.CourseLeassonLearnedsPerUsers", "DeletedBy", c => c.String(maxLength: 128));
            AddColumn("dbo.Incomes", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Incomes", "CreatedAt", c => c.DateTime());
            AddColumn("dbo.Incomes", "CreatedBy", c => c.String(maxLength: 128));
            AddColumn("dbo.Incomes", "UpdatedAt", c => c.DateTime());
            AddColumn("dbo.Incomes", "UpdatedBy", c => c.String(maxLength: 128));
            AddColumn("dbo.Incomes", "DeletedAt", c => c.DateTime());
            AddColumn("dbo.Incomes", "DeletedBy", c => c.String(maxLength: 128));
            AddColumn("dbo.ReviewsPerCouses", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.ReviewsPerCouses", "CreatedAt", c => c.DateTime());
            AddColumn("dbo.ReviewsPerCouses", "CreatedBy", c => c.String(maxLength: 128));
            AddColumn("dbo.ReviewsPerCouses", "UpdatedAt", c => c.DateTime());
            AddColumn("dbo.ReviewsPerCouses", "UpdatedBy", c => c.String(maxLength: 128));
            AddColumn("dbo.ReviewsPerCouses", "DeletedAt", c => c.DateTime());
            AddColumn("dbo.ReviewsPerCouses", "DeletedBy", c => c.String(maxLength: 128));
            AddColumn("dbo.UsersPerCouses", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.UsersPerCouses", "CreatedAt", c => c.DateTime());
            AddColumn("dbo.UsersPerCouses", "CreatedBy", c => c.String(maxLength: 128));
            AddColumn("dbo.UsersPerCouses", "UpdatedAt", c => c.DateTime());
            AddColumn("dbo.UsersPerCouses", "UpdatedBy", c => c.String(maxLength: 128));
            AddColumn("dbo.UsersPerCouses", "DeletedAt", c => c.DateTime());
            AddColumn("dbo.UsersPerCouses", "DeletedBy", c => c.String(maxLength: 128));
            CreateIndex("dbo.Categories", "CreatedBy");
            CreateIndex("dbo.Categories", "UpdatedBy");
            CreateIndex("dbo.Categories", "DeletedBy");
            CreateIndex("dbo.Courses", "CreatedBy");
            CreateIndex("dbo.Courses", "UpdatedBy");
            CreateIndex("dbo.Courses", "DeletedBy");
            CreateIndex("dbo.CourseLeassonLearnedsPerUsers", "CreatedBy");
            CreateIndex("dbo.CourseLeassonLearnedsPerUsers", "UpdatedBy");
            CreateIndex("dbo.CourseLeassonLearnedsPerUsers", "DeletedBy");
            CreateIndex("dbo.Incomes", "CreatedBy");
            CreateIndex("dbo.Incomes", "UpdatedBy");
            CreateIndex("dbo.Incomes", "DeletedBy");
            CreateIndex("dbo.ReviewsPerCouses", "CreatedBy");
            CreateIndex("dbo.ReviewsPerCouses", "UpdatedBy");
            CreateIndex("dbo.ReviewsPerCouses", "DeletedBy");
            CreateIndex("dbo.UsersPerCouses", "CreatedBy");
            CreateIndex("dbo.UsersPerCouses", "UpdatedBy");
            CreateIndex("dbo.UsersPerCouses", "DeletedBy");
            AddForeignKey("dbo.Categories", "CreatedBy", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Categories", "DeletedBy", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Categories", "UpdatedBy", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Courses", "CreatedBy", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Courses", "DeletedBy", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Courses", "UpdatedBy", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.CourseLeassonLearnedsPerUsers", "CreatedBy", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.CourseLeassonLearnedsPerUsers", "DeletedBy", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.CourseLeassonLearnedsPerUsers", "UpdatedBy", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Incomes", "CreatedBy", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Incomes", "DeletedBy", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Incomes", "UpdatedBy", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.ReviewsPerCouses", "CreatedBy", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.ReviewsPerCouses", "DeletedBy", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.ReviewsPerCouses", "UpdatedBy", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.UsersPerCouses", "CreatedBy", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.UsersPerCouses", "DeletedBy", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.UsersPerCouses", "UpdatedBy", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsersPerCouses", "UpdatedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.UsersPerCouses", "DeletedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.UsersPerCouses", "CreatedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.ReviewsPerCouses", "UpdatedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.ReviewsPerCouses", "DeletedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.ReviewsPerCouses", "CreatedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.Incomes", "UpdatedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.Incomes", "DeletedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.Incomes", "CreatedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.CourseLeassonLearnedsPerUsers", "UpdatedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.CourseLeassonLearnedsPerUsers", "DeletedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.CourseLeassonLearnedsPerUsers", "CreatedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.Courses", "UpdatedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.Courses", "DeletedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.Courses", "CreatedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.Categories", "UpdatedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.Categories", "DeletedBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.Categories", "CreatedBy", "dbo.AspNetUsers");
            DropIndex("dbo.UsersPerCouses", new[] { "DeletedBy" });
            DropIndex("dbo.UsersPerCouses", new[] { "UpdatedBy" });
            DropIndex("dbo.UsersPerCouses", new[] { "CreatedBy" });
            DropIndex("dbo.ReviewsPerCouses", new[] { "DeletedBy" });
            DropIndex("dbo.ReviewsPerCouses", new[] { "UpdatedBy" });
            DropIndex("dbo.ReviewsPerCouses", new[] { "CreatedBy" });
            DropIndex("dbo.Incomes", new[] { "DeletedBy" });
            DropIndex("dbo.Incomes", new[] { "UpdatedBy" });
            DropIndex("dbo.Incomes", new[] { "CreatedBy" });
            DropIndex("dbo.CourseLeassonLearnedsPerUsers", new[] { "DeletedBy" });
            DropIndex("dbo.CourseLeassonLearnedsPerUsers", new[] { "UpdatedBy" });
            DropIndex("dbo.CourseLeassonLearnedsPerUsers", new[] { "CreatedBy" });
            DropIndex("dbo.Courses", new[] { "DeletedBy" });
            DropIndex("dbo.Courses", new[] { "UpdatedBy" });
            DropIndex("dbo.Courses", new[] { "CreatedBy" });
            DropIndex("dbo.Categories", new[] { "DeletedBy" });
            DropIndex("dbo.Categories", new[] { "UpdatedBy" });
            DropIndex("dbo.Categories", new[] { "CreatedBy" });
            DropColumn("dbo.UsersPerCouses", "DeletedBy");
            DropColumn("dbo.UsersPerCouses", "DeletedAt");
            DropColumn("dbo.UsersPerCouses", "UpdatedBy");
            DropColumn("dbo.UsersPerCouses", "UpdatedAt");
            DropColumn("dbo.UsersPerCouses", "CreatedBy");
            DropColumn("dbo.UsersPerCouses", "CreatedAt");
            DropColumn("dbo.UsersPerCouses", "Deleted");
            DropColumn("dbo.ReviewsPerCouses", "DeletedBy");
            DropColumn("dbo.ReviewsPerCouses", "DeletedAt");
            DropColumn("dbo.ReviewsPerCouses", "UpdatedBy");
            DropColumn("dbo.ReviewsPerCouses", "UpdatedAt");
            DropColumn("dbo.ReviewsPerCouses", "CreatedBy");
            DropColumn("dbo.ReviewsPerCouses", "CreatedAt");
            DropColumn("dbo.ReviewsPerCouses", "Deleted");
            DropColumn("dbo.Incomes", "DeletedBy");
            DropColumn("dbo.Incomes", "DeletedAt");
            DropColumn("dbo.Incomes", "UpdatedBy");
            DropColumn("dbo.Incomes", "UpdatedAt");
            DropColumn("dbo.Incomes", "CreatedBy");
            DropColumn("dbo.Incomes", "CreatedAt");
            DropColumn("dbo.Incomes", "Deleted");
            DropColumn("dbo.CourseLeassonLearnedsPerUsers", "DeletedBy");
            DropColumn("dbo.CourseLeassonLearnedsPerUsers", "DeletedAt");
            DropColumn("dbo.CourseLeassonLearnedsPerUsers", "UpdatedBy");
            DropColumn("dbo.CourseLeassonLearnedsPerUsers", "UpdatedAt");
            DropColumn("dbo.CourseLeassonLearnedsPerUsers", "CreatedBy");
            DropColumn("dbo.CourseLeassonLearnedsPerUsers", "CreatedAt");
            DropColumn("dbo.CourseLeassonLearnedsPerUsers", "Deleted");
            DropColumn("dbo.Courses", "DeletedBy");
            DropColumn("dbo.Courses", "DeletedAt");
            DropColumn("dbo.Courses", "UpdatedBy");
            DropColumn("dbo.Courses", "UpdatedAt");
            DropColumn("dbo.Courses", "CreatedBy");
            DropColumn("dbo.Courses", "CreatedAt");
            DropColumn("dbo.Courses", "Deleted");
            DropColumn("dbo.Categories", "DeletedBy");
            DropColumn("dbo.Categories", "DeletedAt");
            DropColumn("dbo.Categories", "UpdatedBy");
            DropColumn("dbo.Categories", "UpdatedAt");
            DropColumn("dbo.Categories", "CreatedBy");
            DropColumn("dbo.Categories", "CreatedAt");
            DropColumn("dbo.Categories", "Deleted");
            AlterTableAnnotations(
                "dbo.UsersPerCouses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Completed = c.Boolean(nullable: false),
                        CourseId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                        Deleted = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                        DeletedAt = c.DateTime(),
                        DeletedBy = c.String(maxLength: 128),
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "DynamicFilter_UsersPerCouse_IsDeleted",
                        new AnnotationValues(oldValue: "EntityFramework.DynamicFilters.DynamicFilterDefinition", newValue: null)
                    },
                });
            
            AlterTableAnnotations(
                "dbo.ReviewsPerCouses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Vote = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Commnet = c.String(),
                        CourseId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                        Deleted = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                        DeletedAt = c.DateTime(),
                        DeletedBy = c.String(maxLength: 128),
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "DynamicFilter_ReviewsPerCouse_IsDeleted",
                        new AnnotationValues(oldValue: "EntityFramework.DynamicFilters.DynamicFilterDefinition", newValue: null)
                    },
                });
            
            AlterTableAnnotations(
                "dbo.Incomes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EntityType = c.Int(nullable: false),
                        EntityId = c.Int(nullable: false),
                        IncomeType = c.Int(nullable: false),
                        Todal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Deleted = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                        DeletedAt = c.DateTime(),
                        DeletedBy = c.String(maxLength: 128),
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "DynamicFilter_Income_IsDeleted",
                        new AnnotationValues(oldValue: "EntityFramework.DynamicFilters.DynamicFilterDefinition", newValue: null)
                    },
                });
            
            AlterTableAnnotations(
                "dbo.CourseLeassonLearnedsPerUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LeassonId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                        Deleted = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                        DeletedAt = c.DateTime(),
                        DeletedBy = c.String(maxLength: 128),
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "DynamicFilter_CourseLeassonLearnedsPerUser_IsDeleted",
                        new AnnotationValues(oldValue: "EntityFramework.DynamicFilters.DynamicFilterDefinition", newValue: null)
                    },
                });
            
            AlterTableAnnotations(
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
                        Deleted = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                        DeletedAt = c.DateTime(),
                        DeletedBy = c.String(maxLength: 128),
                        Category_Id = c.Int(),
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "DynamicFilter_Course_IsDeleted",
                        new AnnotationValues(oldValue: "EntityFramework.DynamicFilters.DynamicFilterDefinition", newValue: null)
                    },
                });
            
            AlterTableAnnotations(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Slug = c.String(),
                        Icon = c.String(),
                        Deleted = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                        DeletedAt = c.DateTime(),
                        DeletedBy = c.String(maxLength: 128),
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "DynamicFilter_Category_IsDeleted",
                        new AnnotationValues(oldValue: "EntityFramework.DynamicFilters.DynamicFilterDefinition", newValue: null)
                    },
                });
            
        }
    }
}
