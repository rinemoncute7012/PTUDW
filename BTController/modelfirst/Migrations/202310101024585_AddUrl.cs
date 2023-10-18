namespace modelfirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        maphong = c.String(nullable: false, maxLength: 128),
                        manhanvien = c.String(),
                        tennhanvien = c.String(),
                        ngaysinh = c.DateTime(),
                        luong = c.Decimal(precision: 18, scale: 2),
                        hinhanh = c.String(),
                    })
                .PrimaryKey(t => t.maphong);
            
            CreateTable(
                "dbo.PhongBans",
                c => new
                    {
                        maphong = c.String(nullable: false, maxLength: 128),
                        tenphong = c.String(),
                    })
                .PrimaryKey(t => t.maphong);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.PhongBans");
            DropTable("dbo.NhanViens");
        }
    }
}
