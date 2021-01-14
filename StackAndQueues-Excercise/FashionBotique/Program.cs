using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace FashionBotique
	{
	class Program
		{
		static void Main (string[] args)
		{
			int[] clothes = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			int rackCapacity = int.Parse(Console.ReadLine());
			int ClothBlock = 0;
			int racks = 0;
		   Stack<int> stack = new Stack<int>(clothes);
		   while (stack.Count > 0)
		   {
			   if (ClothBlock + stack.Peek() > rackCapacity)
			   {
				   racks += 1;
				   ClothBlock = 0;
			   }
			   else
			   {
				   ClothBlock += stack.Pop();
			   }
		   }

		   Console.WriteLine(racks + 1);
		}
		}
	}
