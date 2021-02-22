using System;
using System.Collections.Generic;
using System.Linq;

namespace ContinentAndCountries
{
	class Program
	{
		static void Main (string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			Dictionary<string, Dictionary<string, List<string>>> Earth = new Dictionary<string, Dictionary<string, List<string>>>();
			for (int i = 0; i < n; i++)
			{
				string[] input = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.ToArray();
				string Continent = input[0];
				string Country = input[1];
				string City = input[2];

				if (!Earth.ContainsKey(Continent))
				{
					Earth.Add(Continent, new Dictionary<string, List<string>>());
					Earth[Continent].Add(Country, new List<string>());
					Earth[Continent][Country].Add(City);
				}
				else
				{
					if (Earth[Continent].ContainsKey(Country))
					{
						Earth[Continent][Country].Add(City);
					}
					else
					{

						Earth[Continent].Add(Country, new List<string>());
						Earth[Continent][Country].Add(City);
					}
				}
			}

			foreach (var continents in Earth)
			{
				Console.WriteLine($"{continents.Key}:");
				foreach (var Countries in continents.Value)
				{
					Console.Write($"{Countries.Key} -> ");
					Console.Write($"{string.Join(", ", Countries.Value)}");

					Console.WriteLine();
				}
			}
		}
	}
}