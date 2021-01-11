using System;
using System.Collections;
using System.Collections.Generic;

namespace SuperMarket
	{
	class Program
		{
			static void Main(string[] args)
			{
				string input = Console.ReadLine();
				Queue<string> queue = new Queue<string>();
				while (true)
				{
					if (input.ToLower() == "end")
					{
						Console.WriteLine($"{queue.Count} people remaining.");
						break;
					}
					else if (input.ToLower() == "paid")
					{
						foreach (var name in queue)
						{
							   Console.WriteLine(name);
						}
						queue.Clear();
					}
					else
					{
					  queue.Enqueue(input);
					}

					input = Console.ReadLine();

				}
			}
		}
	}
