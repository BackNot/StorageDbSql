namespace Storage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        PurchaseId = c.Int(nullable: false, identity: true),
                        PurchaseDateTime = c.DateTime(nullable: false),
                        Customer_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.PurchaseId)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId)
                .Index(t => t.Customer_CustomerId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        ItemQuantity = c.Int(nullable: false),
                        ItemPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ItemName = c.String(),
                        ItemDescription = c.String(),
                        Purchase_PurchaseId = c.Int(),
                    })
                .PrimaryKey(t => t.ItemId)
                .ForeignKey("dbo.Purchases", t => t.Purchase_PurchaseId)
                .Index(t => t.Purchase_PurchaseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Purchase_PurchaseId", "dbo.Purchases");
            DropForeignKey("dbo.Purchases", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.Items", new[] { "Purchase_PurchaseId" });
            DropIndex("dbo.Purchases", new[] { "Customer_CustomerId" });
            DropTable("dbo.Items");
            DropTable("dbo.Purchases");
            DropTable("dbo.Customers");
        }
    }
}
