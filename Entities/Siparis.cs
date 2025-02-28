using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SubatOdev2.Entities
{
	public class Siparis
	{
		public int SiparisId { get; set; }
		public DateTime SiparisTarihi { get; set; }
		public int KullaniciId { get; set; }
		public Kullanici Kullanici { get; set; }
		public ICollection<SiparisDetay> SiparisDetaylari { get; set; }
	}
}