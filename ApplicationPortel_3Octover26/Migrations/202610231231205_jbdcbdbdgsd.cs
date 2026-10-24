namespace ApplicationPortel_3Octover26.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jbdcbdbdgsd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblRegis1", "RResume", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblRegis1", "RResume", c => c.String(nullable: false));
        }
    }
}
