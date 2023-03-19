using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoSample.SiparisUI.Common
{
	public class Siparis
	{
		public int SiparisID { get; set; }
		public Musteri MusteriID { get; set; }
		public int CalisanID { get; set; } = 1;
		public DateTime SiparisTarihi { get; set; } = DateTime.Now;
		public DateTime IstenilenTeslimatTarihi { get; set; }
		public DateTime KargolamaTarihi { get; set; }
		public KargoSirketi KargoSirketiID { get; set; }

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
