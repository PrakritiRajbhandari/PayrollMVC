namespace PayrollMVC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gender : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Registration", "Gender", c => c.Int(nullable: false));
            DropColumn("dbo.Registration", "Gender");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Registration", "Gender", c => c.Int(nullable: false));
            DropColumn("dbo.Registration", "Gender");
        }
    }
}
