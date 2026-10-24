namespace ApplicationPortel_3Octover26.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dyguihggy : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblRegis1", "RHobbies", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblRegis1", "RHobbies", c => c.Int(nullable: false));
        }
    }
}
