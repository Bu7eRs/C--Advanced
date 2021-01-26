using System;
using System.IO;
using System.Linq;

namespace JaggedArray
	{
	class Program
		{
		static void Main (string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int[,] matrix = new int[n,n];
			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				int[] numbers = Console.ReadLine()
					.Split(" ")
					.Select(int.Parse)
					.ToArray();
				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					matrix[row, col] = numbers[col];
				}
			}
			string input = Console.ReadLine();
			while (true)
			{
				if (input.ToLower().Contains("end"))
				{
					for (int row = 0; row < matrix.GetLength(0); row++)
					{
						for (int col = 0; col < matrix.GetLength(1); col++)
						{
							Console.Write($"{matrix[row,col]} ");
						}

						Console.WriteLine();
					}
					break;
				}
				string[] data = input
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.ToArray();
				string operation = data[0];
				int rows = int.Parse(data[1]);
				int cols = int.Parse(data[2]);
				int number = int.Parse(data[3]);
				if (rows >= matrix.GetLength(0) || cols >= matrix.GetLength(1) || rows < 0 || cols <0 )
				{
					Console.WriteLine($"Invalid coordinates");
					input = Console.ReadLine();
					continue;
				}

				else if (operation.ToLower() == "add")
				{ 
					matrix[rows, cols] += number;
				}
				else if (operation.ToLower() == "subtract")
				{
					matrix[rows, cols] -= number;
				}


				input = Console.ReadLine();
			}
		}
		}
	}
