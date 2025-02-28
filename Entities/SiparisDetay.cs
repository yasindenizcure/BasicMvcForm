using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SubatOdev2.Entities
{
	public class SiparisDetay
	{
		public int SiparisDetayId { get; set; }
		public int SiparisId { get; set; }
		public Siparis Siparis { get; set; }
		public int UrunId { get; set; }
		public Urun Urun { get; set; }
		public int Miktar { get; set; }
		public decimal ToplamFiyat { get; set; }
	}
}