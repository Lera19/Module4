namespace DAL_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Supplier_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_ID)
                .Index(t => t.Supplier_ID);
            
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SupplierShops",
                c => new
                    {
                        Supplier_ID = c.Int(nullable: false),
                        Shop_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Supplier_ID, t.Shop_ID })
                .ForeignKey("dbo.Suppliers", t => t.Supplier_ID, cascadeDelete: true)
                .ForeignKey("dbo.Shops", t => t.Shop_ID, cascadeDelete: true)
                .Index(t => t.Supplier_ID)
                .Index(t => t.Shop_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SupplierShops", "Shop_ID", "dbo.Shops");
            DropForeignKey("dbo.SupplierShops", "Supplier_ID", "dbo.Suppliers");
            DropForeignKey("dbo.Products", "Supplier_ID", "dbo.Suppliers");
            DropIndex("dbo.SupplierShops", new[] { "Shop_ID" });
            DropIndex("dbo.SupplierShops", new[] { "Supplier_ID" });
            DropIndex("dbo.Products", new[] { "Supplier_ID" });
            DropTable("dbo.SupplierShops");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Shops");
            DropTable("dbo.Products");
        }
    }
}
