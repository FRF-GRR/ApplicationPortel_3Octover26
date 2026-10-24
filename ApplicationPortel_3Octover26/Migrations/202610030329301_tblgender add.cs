namespace ApplicationPortel_3Octover26.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class tblgenderadd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblGenders",
                c => new
                {
                    GenderId = c.Int(nullable: false, identity: true),
                    GenderName = c.String(),
                })
                .PrimaryKey(t => t.GenderId);

        }

        public override void Down()
        {
            DropTable("dbo.tblGenders");
        }
    }
}
