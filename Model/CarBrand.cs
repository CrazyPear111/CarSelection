using System;
using System.Collections.Generic;
using System.Text;

namespace EFGetStarted.Model
{
	class CarBrand
	{
		public int CarBrandId { get; set; }		// PrincipalKey
		public string Brand { get; set; }
		public int Year { get; set; }
		public string Body { get; set; }

		public int SellerId { get; set; }		// ForeignKey
		public Seller Seller { get; set; }			// One

		public List<Detail> Details { get; set; }	// Main
	}
}
