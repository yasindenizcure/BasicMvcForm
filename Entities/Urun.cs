using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SubatOdev2.Entities
{
	public class Urun
	{
		public int UrunId { get; set; }
		public string UrunAd { get; set; }
		public decimal Fiyat { get; set; }
		public int KategoriId { get; set; }
		public Kategori Kategori { get; set; }
	}
}