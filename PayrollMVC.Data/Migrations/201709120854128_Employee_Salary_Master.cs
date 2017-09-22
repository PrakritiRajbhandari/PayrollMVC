namespace PayrollMVC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Employee_Salary_Master : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Master",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        EmployeeId = c.Guid(nullable: false),
                        NetSalary = c.String(nullable: false),
                        CreateDate = c.String(nullable: false),
                        CreatedBy = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Registration", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Master", "EmployeeId", "dbo.Registration");
            DropIndex("dbo.Master", new[] { "EmployeeId" });
            DropTable("dbo.Master");
        }
    }
}
