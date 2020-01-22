using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

using EFGetStarted.Model;
using EFGetStarted.Controller;

namespace EFGetStarted
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("\t\t\t\tГЛАВНОЕ МЕНЮ");
				Console.WriteLine("Выберите действие: ");
				Console.WriteLine("\n1 - Регистрация");
				Console.WriteLine("2 - Вход");
				string sw = Console.ReadLine();

				if (sw == "1")
					DBMethod.Registration();

				if (sw == "2")
					DBMethod.Login();
			}


		}
	}
}
