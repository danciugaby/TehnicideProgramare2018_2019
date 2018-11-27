namespace EFSampleDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateStudents : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "A", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "A");
        }
    }
}
