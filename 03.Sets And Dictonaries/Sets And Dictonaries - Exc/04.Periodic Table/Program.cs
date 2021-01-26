using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
	{
	class Program
		{
		static void Main (string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			HashSet<string> Table = new HashSet<string>();
			List<string> list = new List<string>(); 
			for (int i = 0; i < n; i++)
			{
				string[] chemicals = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.ToArray();
				foreach (var chemical in chemicals)
				{
					list.Add(chemical);
				}
				
			}
				 list.Sort();
			foreach (var element in list)
			{
				Table.Add(element);
			}

			Console.WriteLine(string.Join(" ", Table));
		}

		}
	}
