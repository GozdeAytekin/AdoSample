using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoSample.SiparisUI
{
	public class KargoSirketi
	{
		public int KargoSirketiID { get; set; }
		public string KargoSirkeirAdi { get; set; }
		public string KargoSirketiTel { get; set; }

		public override string ToString()
		{
			return KargoSirkeirAdi;
		}
	}
}
