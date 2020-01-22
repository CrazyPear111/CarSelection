using System;
using EFGetStarted.Model;
using EFGetStarted.Controller;

namespace EFGetStarted
{
	class Program
	{
		static void Main(string[] args)
		{
			
			
			

			using (var context = new CarContext())
			{
				UserMethod ob = UserMethod.Registration();

				var seller = new Seller()
				{
					Address = ob.GetAddressToString(),
					Name = ob.Name,
					PhoneNumber = ob.PhoneNumber
				};

				context.Sellers.Add(seller);
				context.SaveChanges();
			}
			
		}
	}
}
