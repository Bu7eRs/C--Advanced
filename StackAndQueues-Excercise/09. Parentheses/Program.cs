using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace Parentheses
	{
	class Program
		{
		static void Main (string[] args)
		{
			string input = Console.ReadLine();
			Stack<char> stack = new Stack<char>();
			bool istrue = true;
			foreach (char item in input)
			{
				if (item == '(' || item == '{' || item == '[')
				{
					stack.Push(item);
				}
				else
				{
					if (item == ')' && stack.Pop() == '(')
					{
					  continue;
					}
					else if (item == '}' && stack.Pop() == '{')
					{
						continue;
					}
					else if (item == ']' && stack.Pop() == '[')
					{
						continue;
					}
					else
					{
						istrue = false;
						Console.WriteLine("NO");
						break;
					}
					}

				
			}
			if (istrue == true)
			{
				Console.WriteLine("YES");
			}
			}
		}
	}
