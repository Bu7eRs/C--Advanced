using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato
	{
		class Program
		{
			static void Main(string[] args)
			{
				string[] names = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.ToArray();
				int count = int.Parse(Console.ReadLine());
				Queue<string> kids = new Queue<string>(names);
				while (kids.Count > 1)
				{
					for (int i = 1; i < count; i++)
					{
						kids.Enqueue(kids.Dequeue());
					}

					Console.WriteLine($"Removed {kids.Dequeue()}");
				}	

				Console.WriteLine($"Last is {kids.Dequeue()}");

			}
		} 
		}		

