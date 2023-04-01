namespace EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.students",
                c => new
                    {
                        masv = c.Int(nullable: false, identity: true),
                        ho = c.String(),
                        ten = c.String(),
                        ngaysinh = c.DateTime(nullable: false),
                        gioiTinh = c.Boolean(nullable: false),
                        danToc = c.String(),
                        matKhau = c.String(),
                    })
                .PrimaryKey(t => t.masv);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.students");
        }
    }
}
