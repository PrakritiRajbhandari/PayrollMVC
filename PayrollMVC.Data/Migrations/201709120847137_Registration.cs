namespace PayrollMVC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Registration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registration",
                c => new
                    {
                        EmployeeId = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false),
                        MiddleName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        Maritalstatus = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Mobile = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false),
                        Address = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Registration");
        }
    }
}
