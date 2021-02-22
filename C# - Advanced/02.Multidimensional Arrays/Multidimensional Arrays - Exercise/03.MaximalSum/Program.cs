using System;
using System.Globalization;
using System.Linq;

namespace MaximalSum
	{
	class Program
		{
		static void Main (string[] args)
		{
			int[] matrixSize = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			int[,] matrix = new int[matrixSize[0], matrixSize[1]];
			int sum = 0;
			int maxsum = 0;
			int fRowPos = 0;
			int fColPos = 0;
			
			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				int[] numbers = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();
				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					matrix[row, col] = numbers[col];
				}
			}

			for (int row = 0; row < matrix.GetLength(0) - 2; row++)
			{
				for (int col = 0; col < matrix.GetLength(1) - 2; col++)
				{
					sum += matrix[row, col];
					sum += matrix[row, col + 1];
					sum += matrix[row, col + 2];

					sum += matrix[row + 1, col];
					sum += matrix[row + 1, col + 1];
					sum += matrix[row + 1, col + 2];

					sum += matrix[row + 2, col];
					sum += matrix[row + 2, col + 1];
					sum += matrix[row + 2, col + 2];
					if (sum > maxsum)
					{
						maxsum = sum;
						fRowPos = row;
						fColPos = col;
					}
					sum = 0;

					}
				}

			Console.WriteLine($"Sum = {maxsum}");
			for (int row = fRowPos; row < fRowPos + 3; row++)
			{
				for (int col = fColPos; col < fColPos+3; col++)
				{
					Console.Write($"{matrix[row,col]} ");
				}

				Console.WriteLine();
			}

		}
		}
	}
