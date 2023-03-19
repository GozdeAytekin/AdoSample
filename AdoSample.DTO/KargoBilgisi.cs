using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoSample.DTO
{
	public class KargoBilgisi
	{
		public int KargoId { get; set; }
		public string KargoAdi { get; set; }
		public string Tel { get; set; }
		public bool? AktifMi { get; set; } 

		public override string ToString()
		{
			return KargoAdi;
		}
	}
}
