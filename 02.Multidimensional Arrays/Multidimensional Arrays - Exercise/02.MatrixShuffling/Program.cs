using System;
using System.Linq;

namespace MatrixShuffling
	{
	class Program
		{
		static void Main (string[] args)
			{
			int[] dimensions = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			string[,] matrix = new string[dimensions[0], dimensions[1]];

			for (int row = 0; row < matrix.GetLength(0); row++)
				{
				string[] matrixNumbers = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.ToArray();
				for (int col = 0; col < matrix.GetLength(1); col++)
					{
					matrix[row, col] = matrixNumbers[col];
					}
				}

			string input = Console.ReadLine();

			while (true)
				{
				string[] pos = input
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.ToArray();
				if (input.ToLower().Contains("end"))
					{
					break;
					}
				else if (input.ToLower().Contains("swap") && pos.Length == 5)
					{
					int firstRow = int.Parse(pos[1]);
					int firstCol = int.Parse(pos[2]);
					int secondRow = int.Parse(pos[3]);
					int secondCol = int.Parse(pos[4]);
					if (firstRow >= matrix.GetLength(0)
						|| firstCol >= matrix.GetLength(1)
						|| secondRow >= matrix.GetLength(0)
						|| secondCol >= matrix.GetLength(1))
					{
						Console.WriteLine($"Invalid input!");
						input = Console.ReadLine();
						continue;
					}
					string save = matrix[firstRow, firstCol];
					matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
					matrix[secondRow, secondCol] = save;
					for (int row = 0; row < matrix.GetLength(0); row++)
						{
						for (int col = 0; col < matrix.GetLength(1); col++)
							{
							Console.Write($"{matrix[row, col]} ");
							}

						Console.WriteLine();
						}
					}
				else
					{
					Console.WriteLine($"Invalid input!");
					}
				input = Console.ReadLine();
				}
			}
		}
	}
