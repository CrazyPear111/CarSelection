using System;
using System.Collections.Generic;
using System.Text;

namespace EFGetStarted.Model
{
	class Detail
	{
		public int DetailId { get; set; }		// PrincipalKey
		public string Module { get; set; }
		public string Name { get; set; }
		public string Price { get; set; }

		public int CarBrandId { get; set; }		// ForeigKey
		public CarBrand CarBrand { get; set; }	// One
	}
}
