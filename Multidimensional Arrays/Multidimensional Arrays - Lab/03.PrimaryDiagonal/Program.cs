using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace PrimaryDiagonal
	{
	class Program
		{
		static void Main (string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[,] matrix = new int[n,n];
			int sum = 0;

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

			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				for (int col = row; col < row+1 ; col++)
				{
					sum += matrix[row, col];
				}

				
			}
			Console.WriteLine(sum);
			}
		}
	}
