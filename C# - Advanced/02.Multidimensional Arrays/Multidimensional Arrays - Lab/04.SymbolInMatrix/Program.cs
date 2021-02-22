using System;

namespace SymbolInMatrix
	{
	class Program
		{
		static void Main (string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			char[,] matrix = new char[n,n];
			bool isfound = false;
			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				char[] input = Console.ReadLine()
					.ToCharArray();
				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					matrix[row, col] = input[col];
				}
			}
			char character = char.Parse(Console.ReadLine());
			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					if (matrix[row,col] == character)
					{
						Console.WriteLine($"({row}, {col})");
						isfound = true;
						break;
					}
					}

				if (isfound == true)
				{
					break;
				}
			}
			if (isfound == false)
			{
				Console.WriteLine($"{character} does not occur in the matrix");
			}
		}
		}
	}
