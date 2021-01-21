using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
	{
	class Program
		{
		static void Main (string[] args)
		{
			int[] numbers = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Reverse()
				.Select(int.Parse)
				.ToArray();
			Stack<int> stack = new Stack<int>();

			foreach (var number in numbers)
			{
				if (number % 2 == 0)
				{
					stack.Push(number);
				}
			}
			Console.Write(string.Join(", ", stack));
		}
		}
	}
