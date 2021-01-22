using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;

namespace MultiDArraysExcercise
	{
	class Program
		{
		static void Main (string[] args)
			{
			int n = int.Parse(Console.ReadLine());
			int[,] matrix = new int[n,n];
			int Fdiagonal = 0;
			int Sdiagonal = 0;
			int counter = n - 1;
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
				Fdiagonal += matrix[row, row];
				Sdiagonal += matrix[row, counter];
				counter--;
			}


			Console.WriteLine(Math.Abs(Fdiagonal - Sdiagonal));
			}
		}
	}
