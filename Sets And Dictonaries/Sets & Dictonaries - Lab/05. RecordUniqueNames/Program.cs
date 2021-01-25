using System;
using System.Collections.Generic;

namespace RecordUniqueNames
	{
	class Program
		{
		static void Main (string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			HashSet<string> Names = new HashSet<string>();
			for (int i = 0; i < n; i++)
			{
				string input = Console.ReadLine();
				Names.Add(input);
			}

			foreach (var name in Names)
			{
				Console.WriteLine(name);
			}
		}
		}
	}
