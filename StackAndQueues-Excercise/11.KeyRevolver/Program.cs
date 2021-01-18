using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
	{
	class Program
		{
		static void Main (string[] args)
		{
			int bulletPrice = int.Parse(Console.ReadLine());
			int gunBarellSize = int.Parse(Console.ReadLine());
			int[] bulletsPower = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			int[] lockHealth = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			int intValue = int.Parse(Console.ReadLine());
			Queue<int> Locks = new Queue<int>(lockHealth);
			Stack<int> bullet = new Stack<int>(bulletsPower);
			bool IsUnlocked = false;
			bool fail = false;

			for (int i = 0; i < bulletsPower.Length; i++)
			{
				for (int j = 0; j < gunBarellSize; j++)
				{
					int currentBullet = bullet.Pop();
					intValue -= bulletPrice;
					int currentlock = Locks.Peek();

					if (currentlock >= currentBullet)
					{
						Console.WriteLine("Bang!");
						Locks.Dequeue();
						
					}
					else
					{
						Console.WriteLine("Ping!");
					}

					if (j == gunBarellSize - 1 )
					{
						Console.WriteLine("Reloading!");
					}
					if (Locks.Count == 0)
					{
						IsUnlocked = true;
						break;
					}
					if (bullet.Count == 0)
					{
						fail = true;
						break;
					}

					
				}
				
				if (fail == true)
				{
					Console.WriteLine($"Couldn't get through. Locks left: {Locks.Count}");
					break;
				}
				else if (IsUnlocked == true)
				{
					Console.WriteLine($"{bullet.Count} bullets left. Earned ${intValue}");
					break;
				}
				}
			
		}
		}
	}
