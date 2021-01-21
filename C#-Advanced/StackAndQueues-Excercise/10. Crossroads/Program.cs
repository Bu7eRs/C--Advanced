using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace Crossroads
	{
	class Program
		{
		static void Main (string[] args)
		{
			int greenLightDuration = int.Parse(Console.ReadLine());
			int freeWindow = int.Parse(Console.ReadLine());
			Queue<string> queue = new Queue<string>();
			int totalpass = 0;
			bool crash = false;
			while (true)
			{
				string input = Console.ReadLine();
				
				if (input.ToLower() == "end")
				{
					Console.WriteLine($"Everyone is safe.");
					Console.WriteLine($"{totalpass} total cars passed the crossroads.");
					break;
				}
				else if (input.ToLower() == "green")
				{
					int currentwindow = greenLightDuration;
					while (currentwindow > 0 && queue.Count > 0)
					{
						int currentcarsize = queue.Peek().Length;
						string currentcar = queue.Dequeue();
						if (currentcarsize > currentwindow + freeWindow)
						{
							Console.WriteLine($"A crash happened!");
							Console.WriteLine($"{currentcar} was hit at {currentcar[freeWindow + currentwindow]}.");
							crash = true;

							break;
						}
						currentwindow -= currentcarsize;


						totalpass += 1;
					}

					if (crash == true)
					{
						break;
					}

					continue;
				}
				queue.Enqueue(input);

				}
		}
		}
	}

