namespace ApplicationPortel_3Octover26.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ndsjscnzncjb : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblRegis1", "RHobbies", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblRegis1", "RHobbies", c => c.String(nullable: false));
        }
    }
}
