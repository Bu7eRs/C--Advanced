		using System;
		using System.Data;
		using System.Linq;
		using System.Numerics;

		namespace JaggedArrayManipulator
			{
			class Program
				{
					static void Main(string[] args)
					{
						int n = int.Parse(Console.ReadLine());
						double[][] matrix = new double[n][];

						for (int row = 0; row < matrix.GetLength(0); row++)
						{
							double[] inputNum = Console.ReadLine()
								.Split(" ", StringSplitOptions.RemoveEmptyEntries)
								.Select(double.Parse)
								.ToArray();
							matrix[row] = inputNum;
						}

						for (int row = 0; row < n - 1; row++)
						{
							if (matrix[row].Length == matrix[row + 1].Length)
							{
								matrix[row] = matrix[row].Select(x => x * 2).ToArray();
								matrix[row + 1] = matrix[row+1].Select(x => x * 2).ToArray();
							}
							else
							{
								matrix[row] = matrix[row].Select(x => x / 2).ToArray();
								matrix[row+1] = matrix[row + 1].Select(x => x / 2).ToArray();
							}
						}

						string input = Console.ReadLine();

						while (true)
						{
							if (input.ToLower().Contains("end"))
							{
								for (int row = 0; row < matrix.GetLength(0); row++)
								{
									for (int col = 0; col < matrix[row].Length; col++)
									{
										Console.Write($"{matrix[row][col]} ");
									}

									Console.WriteLine();
								}

								break;
							}

							string[] commands = input
								.Split(" ", StringSplitOptions.RemoveEmptyEntries)
								.ToArray();
							int currentrow = int.Parse(commands[1]);
							int currentCol = int.Parse(commands[2]);
							if (currentrow < matrix.GetLength(0)
							    && currentrow >= 0
							    && currentCol < matrix[currentrow].Length
							    && currentCol >= 0)
							{
								if (commands[0].ToLower() == "add")
								{
									matrix[currentrow][currentCol] += int.Parse(commands[3]);
								}
								else if (commands[0].ToLower() == "subtract")
								{
									matrix[currentrow][currentCol] -= int.Parse(commands[3]);
								}
							}


						input = Console.ReadLine();
						}
					}
				}
			}
