namespace LTQL249.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_HoaDon : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        MaHoaDon = c.String(nullable: false, maxLength: 128, unicode: false),
                        NgayTao = c.String(unicode: false),
                        MaKhachHang = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.MaHoaDon);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HoaDons");
        }
    }
}
