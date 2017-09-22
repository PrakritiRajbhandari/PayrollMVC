namespace PayrollMVC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Salary : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.salaries",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        EmployeeName = c.String(nullable: false),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.salaries");
        }
    }
}
