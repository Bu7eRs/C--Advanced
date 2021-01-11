using System;
using System.Collections;
using System.Collections.Generic;

namespace Reverse_String
	{
	class Program
		{
		static void Main (string[] args)
		{
			string input = Console.ReadLine();
			var Stack = new Stack<char>();
			foreach (var ch in input)
			{
			Stack.Push(ch);
			}

			while (Stack.Count != 0)
			{
				Console.Write(Stack.Pop());
			}

		}
		}
	}
