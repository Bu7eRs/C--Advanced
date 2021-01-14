using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
	{
	class Program
		{
		static void Main (string[] args)
		{
			int[] xyz = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			int popR = xyz[1];	  //Pop Repeats
			int wanted = xyz[2];  //Number that we search for.
			int[] numbers = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			bool isfound = false;
			Stack<int> stack = 	 new Stack<int>(numbers);
			for (int i = 0; i < popR; i++)
			{
				stack.Pop();
			}

			foreach (var num in stack)
			{
				if (num == wanted)
				{
					Console.WriteLine("true");
					isfound = true;
					break;
				}
			}

			if (isfound == false)
			{
				Console.WriteLine(stack.Min());
			}
			else if (stack.Count == 0)
			{
				Console.WriteLine("0");
			}
		}
		}
	}
