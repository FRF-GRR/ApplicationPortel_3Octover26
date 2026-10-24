namespace ApplicationPortel_3Octover26.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class vgyfug : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblRegis1", "RDepartment", c => c.Int());
        }

        public override void Down()
        {
            AlterColumn("dbo.tblRegis1", "RDepartment", c => c.Int(nullable: false));
        }
    }
}
