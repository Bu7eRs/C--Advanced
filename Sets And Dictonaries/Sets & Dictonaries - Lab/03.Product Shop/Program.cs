using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace ProductShop
	{
	class Program
		{
		static void Main (string[] args)
		{
			string input = Console.ReadLine();
			SortedDictionary<string, Dictionary<string, double>> stores = new SortedDictionary<string, Dictionary<string, double>>();
			while (true)
			{
				if (input.ToLower().Contains("revision"))
				{
					foreach (var store in stores)
					{
						Console.WriteLine($"{store.Key}->");
						foreach (var products in store.Value)
						{
							Console.WriteLine($"Product: {products.Key}, Price: {products.Value}");	
						}
					}
					break;
				}

				string[] data = input
					.Split(", ", StringSplitOptions.RemoveEmptyEntries)
					.ToArray();
				string Store = data[0];
				string product = data[1];
				double price = double.Parse(data[2]);
				if (stores.ContainsKey(Store))
				{
					stores[Store].Add(product, price);
				}
				else
				{
					stores.Add(Store, new Dictionary<string, double>());
					stores[Store].Add(product, price);
				}
				input = Console.ReadLine();
			}
		}
		}
	}
