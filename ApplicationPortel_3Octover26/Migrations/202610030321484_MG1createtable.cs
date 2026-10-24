namespace ApplicationPortel_3Octover26.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MG1createtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblCities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        stateId = c.Int(nullable: false),
                        CityName = c.String(),
                    })
                .PrimaryKey(t => t.CityId);
            
            CreateTable(
                "dbo.tblCountries",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        CountryName = c.String(),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.tblDepartments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.tblHobbies",
                c => new
                    {
                        HobbiesId = c.Int(nullable: false, identity: true),
                        HobbiesName = c.String(),
                    })
                .PrimaryKey(t => t.HobbiesId);
            
            CreateTable(
                "dbo.tblStates",
                c => new
                    {
                        StateId = c.Int(nullable: false, identity: true),
                        CountryId = c.Int(nullable: false),
                        StateName = c.String(),
                    })
                .PrimaryKey(t => t.StateId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblStates");
            DropTable("dbo.tblHobbies");
            DropTable("dbo.tblDepartments");
            DropTable("dbo.tblCountries");
            DropTable("dbo.tblCities");
        }
    }
}
