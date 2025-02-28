namespace SubatOdev2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        KategoriId = c.Int(nullable: false, identity: true),
                        KategoriAd = c.String(),
                    })
                .PrimaryKey(t => t.KategoriId);
            
            CreateTable(
                "dbo.Uruns",
                c => new
                    {
                        UrunId = c.Int(nullable: false, identity: true),
                        UrunAd = c.String(),
                        Fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        KategoriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UrunId)
                .ForeignKey("dbo.Kategoris", t => t.KategoriId, cascadeDelete: true)
                .Index(t => t.KategoriId);
            
            CreateTable(
                "dbo.Kullanicis",
                c => new
                    {
                        KullaniciId = c.Int(nullable: false, identity: true),
                        KullaniciAd = c.String(),
                        KullaniciEmail = c.String(),
                    })
                .PrimaryKey(t => t.KullaniciId);
            
            CreateTable(
                "dbo.Siparis",
                c => new
                    {
                        SiparisId = c.Int(nullable: false, identity: true),
                        SiparisTarihi = c.DateTime(nullable: false),
                        KullaniciId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SiparisId)
                .ForeignKey("dbo.Kullanicis", t => t.KullaniciId, cascadeDelete: true)
                .Index(t => t.KullaniciId);
            
            CreateTable(
                "dbo.SiparisDetays",
                c => new
                    {
                        SiparisDetayId = c.Int(nullable: false, identity: true),
                        SiparisId = c.Int(nullable: false),
                        UrunId = c.Int(nullable: false),
                        Miktar = c.Int(nullable: false),
                        ToplamFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SiparisDetayId)
                .ForeignKey("dbo.Siparis", t => t.SiparisId, cascadeDelete: true)
                .ForeignKey("dbo.Uruns", t => t.UrunId, cascadeDelete: true)
                .Index(t => t.SiparisId)
                .Index(t => t.UrunId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SiparisDetays", "UrunId", "dbo.Uruns");
            DropForeignKey("dbo.SiparisDetays", "SiparisId", "dbo.Siparis");
            DropForeignKey("dbo.Siparis", "KullaniciId", "dbo.Kullanicis");
            DropForeignKey("dbo.Uruns", "KategoriId", "dbo.Kategoris");
            DropIndex("dbo.SiparisDetays", new[] { "UrunId" });
            DropIndex("dbo.SiparisDetays", new[] { "SiparisId" });
            DropIndex("dbo.Siparis", new[] { "KullaniciId" });
            DropIndex("dbo.Uruns", new[] { "KategoriId" });
            DropTable("dbo.SiparisDetays");
            DropTable("dbo.Siparis");
            DropTable("dbo.Kullanicis");
            DropTable("dbo.Uruns");
            DropTable("dbo.Kategoris");
        }
    }
}
