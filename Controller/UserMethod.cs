using System;
using System.Collections.Generic;
using System.Text;

namespace EFGetStarted.Controller
{
	class UserMethod
	{
		#region FieldsAndProperties

		public enum UserTypes { seller, customer};
		public UserTypes UserType { get; protected set; }
		public string Name { get; protected set; }
		public string PhoneNumber { get; protected set; }
		public struct AddressStruct
		{
			public string Country;
			public string Sity;
			public string Street;
			public string House;
		}
		public AddressStruct Address;

		#endregion				
		public static UserMethod Registration()			// Возвращает зарегистрированного пользователя
		{
			UserMethod user = new UserMethod();

			Console.WriteLine("\t\t\tРЕГИСТРАЦИЯ ПОЛЬЗОВАТЕЛЯ\n");
			Console.Write("Введите имя: ");
			user.Name = Console.ReadLine();

			Console.Write("Введите номер телефона: ");
			user.PhoneNumber = Console.ReadLine();


			Console.WriteLine("Введите адрес: ");
			Console.Write("\tСтрана: ");
			user.Address.Country = Console.ReadLine();
			Console.Write("\tГород: ");
			user.Address.Sity = Console.ReadLine();
			Console.Write("\tУлица: ");
			user.Address.Street = Console.ReadLine();
			Console.Write("\tДом: ");
			user.Address.House = Console.ReadLine();

			bool fail;	// Переменная для выхода из цикла
			do
			{
				fail = false;
				Console.WriteLine("Вы хотите продать или купить детали? \n\t1 - Продать\n\t2 - Купить");
				string ut = Console.ReadLine();
				if (ut == "1" || ut == "2")
					if (ut == "1")
					{
						Console.WriteLine("\nВыбран профиль продавца");
						user.UserType = UserTypes.seller;
					}
					else
					{
						Console.WriteLine("\nВыбран профиль покупателя");
						user.UserType = UserTypes.customer;
					}
				else
				{
					Console.WriteLine("\nВведите 1 или 2");
					fail = true;
				}
			} while (fail);

			Console.WriteLine("\nРегистрация успешно завершена. Новый профиль добавлен в базу данных.");

			return user;
		}
		
		public string GetAddressToString()
		{
			string addr = null;

			addr += Address.Country;
			addr += ", ";
			addr += Address.Sity;
			addr += ", ";
			addr += Address.Street;
			addr += ", ";
			addr += Address.House;

			return addr;
		}
	}
}
