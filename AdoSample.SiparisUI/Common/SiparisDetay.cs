using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoSample.SiparisUI.Common
{
	public class SiparisDetay
	{
		public int SiparisId { get; set; }
		public Urun UrunId { get; set; }
		public double UrunBirimFiyat { get; set; }
		public byte UrunAdetSayisi { get; set; }
		public Single UrunIndirimOrani { get; set; }
	}
}
