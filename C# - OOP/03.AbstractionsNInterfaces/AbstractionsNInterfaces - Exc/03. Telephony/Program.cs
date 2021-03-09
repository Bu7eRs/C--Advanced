using System;
using System.Linq;

namespace Telephony
	{
	class Program
		{
		static void Main (string[] args)
		{
			string[] numbers = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.ToArray();


			for (int i = 0; i < numbers.Length; i++)
			{
				try
				{
					if (numbers[i].Length == 7)
					{
						StationaryPhone StatPhone = new StationaryPhone(numbers[i]);
						StatPhone.Call();
					}
					else if (numbers[i].Length == 10)
					{
						Smartphone currSmarPhone = new Smartphone();
						currSmarPhone.Number = numbers[i];
						currSmarPhone.Call();
					}
					else
					{
						Console.WriteLine($"Invalid number!");
					}

				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}

			string[] Urls = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.ToArray();

			for (int i = 0; i < Urls.Length; i++)
			{
				try
				{
					Smartphone currSmartPhone = new Smartphone();
					currSmartPhone.Url = Urls[i];
					currSmartPhone.Browse();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
				
			}
		}
		}
	}
