using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SubatOdev2.Entities
{
	public class Kategori
	{
		public int KategoriId { get; set; }
		public string KategoriAd { get; set; }
		public ICollection<Urun> Urunler { get; set; }
	}
}