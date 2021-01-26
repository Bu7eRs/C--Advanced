	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;

	namespace Stack_Sum
		{
		class Program
			{
				static void Main(string[] args)
				{
					int[] numbers = Console.ReadLine()
						.Split(" ", StringSplitOptions.RemoveEmptyEntries)
						.Select(int.Parse)
						.ToArray();
					Stack<int> stack = new Stack<int>(numbers);
					string input = string.Empty;

					while ((input = Console.ReadLine().ToLower()) != "end")
					{
						string[] command = input
							.Split(" ", StringSplitOptions.RemoveEmptyEntries)
							.ToArray();
						string operation = command[0].ToLower();
						if (operation == "add")
						{
							stack.Push(int.Parse(command[1]));
							stack.Push(int.Parse(command[2]));
						}
						else if (operation == "remove")
						{
							int index = int.Parse(command[1]);
							if(index >0 && index <= stack.Count)
							for (int i = 0; i < index; i++)
							{
								stack.Pop();
							}
						}
					}

					Console.WriteLine($"Sum: {stack.Sum()}");

				}
			}
			}

