using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoSample.SiparisUI.Common
{
	public class Musteri
	{
		public string MusteriID { get; set; }

		public string SirketAdi { get; set; }

		public string MusteriAdi { get; set; }

		public string MusteriPozisyonu { get; set; }

		public string MusteriAdresi { get; set; }

		public string Sehir { get; set; }

		public string Bolge { get; set; }

		public string PostaKodu { get; set; }

		public string Ulke { get; set; }

		public string TelefonNo { get; set; }

		public string FaxNo { get; set; }

		public override string ToString()
		{
			return SirketAdi;
		}
	}
}
