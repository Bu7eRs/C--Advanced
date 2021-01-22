using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace SquareWithMaximumSum
	{
	class Program
		{
		static void Main (string[] args)
		{
			int[] n = Console.ReadLine()
				.Split(", ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			int[,] matrix = new int[n[0],n[1]];
			int sum = int.MinValue;
			int value = 0;
			string Fposition = string.Empty;
			string Sposition = string.Empty;
			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				int[] numbers = Console.ReadLine()
					.Split(", ", StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();
				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					matrix[row, col] = numbers[col];
				}	
			}

			for (int row = 0; row < matrix.GetLength(0)- 1; row++)
			{
				for (int col = 0; col < matrix.GetLength(1)- 1; col++)
				{
					value = 0;
					value += matrix[row, col] + matrix[row, col + 1] 
						+ matrix[row + 1, col] + matrix[row+1, col + 1];
					if (value > sum)
					{
						sum = value;
						Fposition = $"{matrix[row, col]} {matrix[row, col+1]}";
						Sposition = $"{matrix[row+ 1, col]} {matrix[row+1, col+1]}";
					}
				}
			}
			Console.WriteLine(Fposition);
			Console.WriteLine(Sposition);
			Console.WriteLine(sum);
		}
		}
	}
