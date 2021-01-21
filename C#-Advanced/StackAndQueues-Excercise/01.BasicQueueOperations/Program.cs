using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
	{
	class Program
		{
		static void Main (string[] args)
		{
			int[] xyz = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			int dequeueR = xyz[1];	//Represent element remove repeats
			int wanted = xyz[2];            //Represents the number that we searching for.
			int[] numbers = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			Queue<int> queue = new Queue<int>(numbers);
			bool isfound = false;
			 for (int i = 0; i < dequeueR; i++)
			 {
				 queue.Dequeue();
			 }

			 foreach (var num in queue)
			 {
				 if (num == wanted)
				 {
					 Console.WriteLine("true");
					 isfound = true;
					 break;
				 }
			 }

			 if (queue.Count == 0)
			 {
				 Console.WriteLine("0");
			 }

			 else if (isfound == false)
			 {
				 Console.WriteLine(queue.Min());
			 }
		}
		}
	}
