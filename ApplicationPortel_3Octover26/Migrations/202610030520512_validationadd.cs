namespace ApplicationPortel_3Octover26.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validationadd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblRegis1", "RPassword", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblRegis1", "RPassword", c => c.String(nullable: false));
        }
    }
}
