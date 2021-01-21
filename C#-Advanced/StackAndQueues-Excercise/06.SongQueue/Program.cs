using System;
using System.Collections.Generic;
using System.Linq;

namespace SongQueue
	{
	class Program
		{
		static void Main (string[] args)
		{
			string input = Console.ReadLine();
			string[] songs = input
				.Split(", ", StringSplitOptions.RemoveEmptyEntries)
				.ToArray();
			Queue<string> queue = new Queue<string>(songs);
			while (true)
			{
				if (queue.Count == 0)
				{
					Console.WriteLine("No more songs!");
					break;
				}

				else if (input.ToLower() == "play")
				{
					queue.Dequeue();
				}
				else if (input.ToLower().Contains("add"))
				{
					string song =  input.Substring(4, input.Length - 4);
					if (queue.Contains(song))
					{
						Console.WriteLine($"{song} is already contained!");
					}
					else
					{
						queue.Enqueue(song);
					}
				}
				else if (input.ToLower() == "show")
				{
					Console.WriteLine(string.Join(", ", queue));
				}

				input = Console.ReadLine();
			}

		}
		}
	}
