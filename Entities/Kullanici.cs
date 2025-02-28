using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SubatOdev2.Entities
{
	public class Kullanici
	{
		public int KullaniciId { get; set; }
		public string KullaniciAd { get; set; }
		public string KullaniciEmail { get; set; }

		public ICollection<Siparis> Siparisler { get; set; }

	}
}
