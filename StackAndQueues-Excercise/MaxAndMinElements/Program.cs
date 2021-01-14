using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxAndMinElements
	{
	class Program
		{
		static void Main (string[] args)
		{
			int repeats = int.Parse(Console.ReadLine());
			Stack<int> stack = new Stack<int>();
			for (int i = 0; i < repeats; i++)
			{
				int[] input = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();
				string command = input[0].ToString();
				if (command == "1")
				{
					stack.Push(input[1]);
				}
				if (stack.Count == 0)
				{
					continue;
				}
				else if (command == "2")
				{
					stack.Pop();
				}
				else if (command == "3")
				{
					Console.WriteLine(stack.Max());
				}
				else if (command == "4")
				{
					Console.WriteLine(stack.Min());
				}
			}

			Console.WriteLine(string.Join(", ", stack));
		}
		}
	}
