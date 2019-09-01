namespace _2KOLKIT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imeMigracija : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Name", c => c.String());
        }
    }
}
