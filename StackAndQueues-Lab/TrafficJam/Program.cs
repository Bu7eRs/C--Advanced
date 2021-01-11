using System;
using System.Collections.Generic;

namespace TrafficJam
	{
	class Program
		{
		static void Main (string[] args)
		{
			int passCount = int.Parse(Console.ReadLine());

			string input = Console.ReadLine();
			Queue<string> traffic = new Queue<string>();
			int count = 0;
			while (true)
			{

				if (input.ToLower() == "end")
				{
					Console.WriteLine($"{count} cars passed the crossroads.");
					break;
				}
				else if (input.ToLower() == "green")
				{
					if (passCount > traffic.Count)
					{
						passCount = traffic.Count;
					}

					for (int i = 0; i < passCount  ; i++)
					{
						Console.WriteLine($"{traffic.Dequeue()} passed!");
						count += 1;
					}
				}
				else
				{
					traffic.Enqueue(input);
				}
				
				input = Console.ReadLine();
			}
		}
		}
	}
