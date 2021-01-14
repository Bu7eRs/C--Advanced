	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;

	namespace FastFood
		{
		class Program
			{
			static void Main (string[] args)
				{
				int quantity = int.Parse(Console.ReadLine());
				int[] orders = Console.ReadLine()
						.Split(" ", StringSplitOptions.RemoveEmptyEntries)
						.Select(int.Parse)
						.ToArray();
				Queue<int> queue = new Queue<int>(orders);
				Console.WriteLine(queue.Max());
				foreach (var order in orders)
				{
					{
						if (order > quantity)
						{
							Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
							break;
						}
						else
						{
						quantity -= queue.Dequeue();
						}
					}
				}
				 if (queue.Count == 0)
						{
						Console.WriteLine($"Orders complete");
						}
					}
			}

		}