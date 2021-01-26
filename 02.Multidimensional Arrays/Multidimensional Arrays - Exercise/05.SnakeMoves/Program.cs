using System;
using System.Linq;
using System.Numerics;

namespace SnakeMoves
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
			int currentLetter = 0;
			string snake = Console.ReadLine();

			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				if (row % 2 == 0)
				{
					for (int col = 0; col < matrix.GetLength(1); col++)
					{
						matrix[row, col] = snake[currentLetter];
						currentLetter++;
						if (currentLetter == snake.Length)
						{
							currentLetter = 0;
						}
					}
				}
				else
				{
					for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
					{
						matrix[row, col] = snake[currentLetter];
						currentLetter++;
						if (currentLetter == snake.Length)
						{
							currentLetter = 0;
						}
					}
					}
				
			}

			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					Console.Write(matrix[row,col]);
				}

				Console.WriteLine();
			}
		}
		}
	}
