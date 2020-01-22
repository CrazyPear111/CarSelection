using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using EFGetStarted.Controller;

namespace EFGetStarted.Model
{
	class DBMethod
	{
		public static void Registration()
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
		
		public static void Login()
		{
			using (var context = new CarContext())
			{
				UserMethod ob = UserMethod.Login();

				try
				{
					var seller = context.Sellers.Single(s => s.Name == ob.Name);

					ob.EnableUser(seller);

					ob.ShowUser();
				}
				catch(InvalidOperationException)
				{
					Console.WriteLine("Шо за хуйню ты ввел??? Нет там такого имени\n");
				}

			}
		}
	}
}
