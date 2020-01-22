using System;
using System.Collections.Generic;
using System.Text;

namespace EFGetStarted.Model
{
	class Seller
	{
		public int SellerId { get; set; }               // PrincipalKey
		public string Address { get; set; }
		public string Name { get; set; }
		public string PhoneNumber { get; set; }

		public List<CarBrand> CarBrands { get; set; }	// Main
	}
}
