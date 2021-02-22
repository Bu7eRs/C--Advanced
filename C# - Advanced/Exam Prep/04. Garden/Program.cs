    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices.ComTypes;

    namespace Garden
    {
        class Program
        {
            static void Main(string[] args)
            {
                int[] matrixDimenssions = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int[,] matrix = new int[matrixDimenssions[0], matrixDimenssions[1]];

                for (int Row = 0; Row < matrix.GetLength(0); Row++)
                {

                    for (int Col = 0; Col < matrix.GetLength(1); Col++)
                    {
                        matrix[Row, Col] = 0;
                    }
                }

                List<int> PositionData = new List<int>();
                string input = Console.ReadLine();
                while (true)
                {
                   
                    if (input == "Bloom Bloom Plow")
                    {
                        for (int i = 0; i <PositionData.Count + 1/ 2 ; i+= 2)
                        {
                            int currRow = PositionData[i];
                            int currCol = PositionData[i + 1];
                            
                                for (int Rows = 0; Rows < matrix.GetLength(0); Rows++)
                                {
                                    matrix[Rows, currCol] += 1;
                                }

                                for (int Cols = 0; Cols < matrix.GetLength(1); Cols++)
                                {
                                    
                                    matrix[currRow, Cols] += 1;
                                }

                                matrix[currRow, currCol] -= 1;
                        }
                        
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write($"{matrix[i,j]} ");
                            }

                            Console.WriteLine();
                        }
                        break;

                    }
                    int[] data = input
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                    int Row = data[0];
                    int Col = data[1];

                    if (Row < 0 || Row > matrix.GetLength(1) 
                                || Col < 0 || Col > matrix.GetLength(0))
                    {
                        Console.WriteLine($"Invalid coordinates.");
                    }
                    else
                    {
                        PositionData.Add(Row);
                        PositionData.Add(Col);
                    }

                    input = Console.ReadLine();
                }
            }
        }
    }
