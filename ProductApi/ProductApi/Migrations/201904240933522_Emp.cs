namespace ProductApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Emp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        DateOfJoining = c.DateTime(nullable: false),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Department = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
