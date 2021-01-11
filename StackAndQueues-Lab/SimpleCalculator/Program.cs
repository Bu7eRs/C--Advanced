	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using System.Runtime.InteropServices.ComTypes;

	namespace SimpleCalculator
		{
		class Program
			{
			static void Main (string[] args)
			{
				string[] input = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.Reverse()
					.ToArray();
			   Stack<string> calculate = new Stack<string>(input);

			   while (calculate.Count > 1)
			   {
				   int firstnumber = int.Parse(calculate.Pop());
				   string operation = calculate.Pop();
				   int secondnumber = int.Parse(calculate.Pop());

				   if (operation == "+")
				   {
					   calculate.Push((firstnumber + secondnumber).ToString());
				   }
				   else if (operation == "-")
				   {
					   calculate.Push((firstnumber - secondnumber).ToString());
				   }
			   }

			   Console.WriteLine(calculate.Pop());
			}
			}
		}
