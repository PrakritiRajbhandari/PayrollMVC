namespace PayrollMVC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Employee_Salary_Details : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Details",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        EmployeeId = c.Guid(nullable: false),
                        Type = c.String(nullable: false),
                        Earning = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Deduction = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Registration", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Details", "EmployeeId", "dbo.Registration");
            DropIndex("dbo.Details", new[] { "EmployeeId" });
            DropTable("dbo.Details");
        }
    }
}
