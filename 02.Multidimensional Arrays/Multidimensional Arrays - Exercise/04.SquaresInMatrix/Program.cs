using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace SquaresInMatrix
	{
	class Program
		{
		static void Main (string[] args)
		{
			int[] dimenssions = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			char[,] matrix = new char[dimenssions[0], dimenssions[1]];
			char currentChar = ' ';
			int sum = 0;
			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				char[] input = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.Select(char.Parse)
					.ToArray();
				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					matrix[row, col] = input[col];
				}
			}

			for (int row = 0; row < matrix.GetLength(0)- 1; row++)
			{
				for (int col = 0; col < matrix.GetLength(1)- 1; col++)
				{
					currentChar = matrix[row, col];
					if (currentChar == matrix[row, col + 1]
					    && matrix[row + 1, col] == currentChar
					    && currentChar == matrix[row + 1, col + 1])
					{
						sum += 1;
					}
				}
			}

			Console.WriteLine(sum);

		}
		}
	}
