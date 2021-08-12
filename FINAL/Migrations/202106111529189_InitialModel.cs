namespace FINAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DiemHP",
                c => new
                    {
                        MaSV = c.Int(nullable: false),
                        MaMH = c.String(nullable: false, maxLength: 20),
                        Diem = c.Double(),
                    })
                .PrimaryKey(t => new { t.MaSV, t.MaMH })
                .ForeignKey("dbo.Monhoc", t => t.MaMH)
                .ForeignKey("dbo.Sinhvien", t => t.MaSV)
                .Index(t => t.MaSV)
                .Index(t => t.MaMH);
            
            CreateTable(
                "dbo.Monhoc",
                c => new
                    {
                        MaMH = c.String(nullable: false, maxLength: 20),
                        TenMH = c.String(maxLength: 50),
                        SoTC = c.Int(),
                    })
                .PrimaryKey(t => t.MaMH);
            
            CreateTable(
                "dbo.Sinhvien",
                c => new
                    {
                        MaSV = c.Int(nullable: false),
                        TenSV = c.String(maxLength: 100),
                        Ngaysinh = c.String(maxLength: 50),
                        Gioitinh = c.String(maxLength: 50),
                        Diachi = c.String(maxLength: 50),
                        Malop = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.MaSV)
                .ForeignKey("dbo.Lop", t => t.Malop)
                .Index(t => t.Malop);
            
            CreateTable(
                "dbo.Lop",
                c => new
                    {
                        Malop = c.String(nullable: false, maxLength: 20),
                        Tenlop = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Malop);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sinhvien", "Malop", "dbo.Lop");
            DropForeignKey("dbo.DiemHP", "MaSV", "dbo.Sinhvien");
            DropForeignKey("dbo.DiemHP", "MaMH", "dbo.Monhoc");
            DropIndex("dbo.Sinhvien", new[] { "Malop" });
            DropIndex("dbo.DiemHP", new[] { "MaMH" });
            DropIndex("dbo.DiemHP", new[] { "MaSV" });
            DropTable("dbo.Lop");
            DropTable("dbo.Sinhvien");
            DropTable("dbo.Monhoc");
            DropTable("dbo.DiemHP");
        }
    }
}
