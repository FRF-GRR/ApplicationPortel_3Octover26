namespace ApplicationPortel_3Octover26.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class registrationpageadd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblRegis1",
                c => new
                    {
                        RId = c.Int(nullable: false, identity: true),
                        RName = c.String(nullable: false),
                        REmail = c.String(nullable: false),
                        RPassword = c.String(nullable: false),
                        RMobile = c.Long(nullable: false),
                        RDob = c.DateTime(nullable: false),
                        RAge = c.Int(nullable: false),
                        RDepartment = c.Int(nullable: false),
                        RGender = c.Int(nullable: false),
                        RHobbies = c.Int(nullable: false),
                        RCountry = c.Int(nullable: false),
                        RState = c.Int(nullable: false),
                        RCity = c.Int(nullable: false),
                        RResume = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblRegis1");
        }
    }
}
