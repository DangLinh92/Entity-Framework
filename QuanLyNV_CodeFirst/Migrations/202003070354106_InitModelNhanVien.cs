namespace QuanLyNV_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitModelNhanVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NHAN_VIEN",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 10, unicode: false),
                        HoTen = c.String(maxLength: 30),
                        GioiTinh = c.Int(nullable: false),
                        NgaySinh = c.DateTime(nullable: false),
                        DienThoai = c.String(maxLength: 20, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                        DiaChi = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.MaNV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NHAN_VIEN");
        }
    }
}
