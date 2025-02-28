using SubatOdev2.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SubatOdev2.Context
{
	public class VeritabaniContext: DbContext
	{
        public VeritabaniContext() : base("SiparisDB") { }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Siparis> Siparisler  { get; set; }
        public DbSet<SiparisDetay> SiparisDetaylari  { get; set; }

    }
}