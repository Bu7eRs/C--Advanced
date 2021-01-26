using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
	{
	class Program
		{
		static void Main (string[] args)
		{
			int[] input = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			int n = input[0];
			int m = input[1];
			HashSet<int> First = new HashSet<int>();
			HashSet<int> Second = new HashSet<int>();
			HashSet<int> Final  = new HashSet<int>();
			for (int i = 0; i < n; i++)
			{
				int firstSetInput = int.Parse(Console.ReadLine());
				First.Add(firstSetInput);
			}
			for (int i = 0; i < m; i++)
			{
				int secondSetInput = int.Parse(Console.ReadLine());
				Second.Add(secondSetInput);
			}

			foreach (var number in First)
			{
				foreach (var num in Second)
				{
					if (num == number)
					{
						Final.Add(num);
					}
				}
			}

			Console.WriteLine($"{string.Join(" ", Final)}");
		}
		}
	}
