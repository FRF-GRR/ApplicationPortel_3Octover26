namespace ApplicationPortel_3Octover26.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ndnnfsd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblEmployees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(),
                        EmployeeEmail = c.String(),
                        EmployeePassword = c.String(),
                        EmployeeResume = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblEmployees");
        }
    }
}
