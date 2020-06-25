namespace DAL_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EdinNameShop : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Shops", "Name", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Shops", "Name", c => c.String());
        }
    }
}
