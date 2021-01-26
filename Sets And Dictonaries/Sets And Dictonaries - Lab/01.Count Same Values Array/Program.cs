using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesArray
	{
	class Program
		{
		static void Main (string[] args)
		{
			string[] arrNums = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.ToArray();
			Dictionary<string, int> dict = new Dictionary<string, int>();
			for (int i = 0; i < arrNums.Length; i++)
			{
				string currentIndex = arrNums[i];
				if (dict.ContainsKey(currentIndex))
				{
					continue;
				}
				for (int j = 0; j < arrNums.Length; j++)
				{
					string currentcheck = arrNums[j];
					
					if (currentIndex == currentcheck && dict.ContainsKey(currentcheck))
					{
						dict[currentIndex]++;
					}
					else if (arrNums[j] == currentIndex)
					{
						dict.Add(currentIndex, 1);
					}
					
				}

			}

			foreach (var value in dict)
			{
				Console.WriteLine($"{value.Key} - {value.Value} times");
			}
			}
		}
	}
