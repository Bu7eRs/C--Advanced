using System;
using System.Globalization;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            int[] SnakeCordinates = new int[2];
            int[] burrowCordinates = new int[4];
            int index = 0;
            for (int Row = 0; Row < matrix.GetLength(0); Row++)
            {
                char[] matrixInput = Console.ReadLine()
                    .ToCharArray();

                for (int Col = 0; Col < matrix.GetLength(1); Col++)
                {
                    if (matrixInput[Col] == 'B')
                    {
                        burrowCordinates[index] = Row;
                        index++;
                        burrowCordinates[index] = Col;
                        index++;
                    }
                    else if (matrixInput[Col] == 'S')
                    {
                        SnakeCordinates[0] = Row;
                        SnakeCordinates[1] = Col;
                    }

                matrix[Row, Col] = matrixInput[Col];
                }
            }

            string input = Console.ReadLine();
            int foodEaten = 0;
            bool isOut = false;
            int currentSnakeRow = SnakeCordinates[0];
            int currentSnakeCol = SnakeCordinates[1];
            while (true)
            {

             
                if (input.ToLower() == "left")
                {
                    matrix[currentSnakeRow, currentSnakeCol] = '.';
                    currentSnakeCol -= 1;
                    if (currentSnakeCol < 0)
                    {
                        isOut = true;
                        break;
                    }
                    else
                    {
                        if (matrix[currentSnakeRow, currentSnakeCol] == '*')
                        {
                            foodEaten++;
                            matrix[currentSnakeRow, currentSnakeCol] = 'S';
                            if (foodEaten >= 10)
                            {
                                break;
                            }
                        }
                        else if (matrix[currentSnakeRow, currentSnakeCol] == 'B')
                        {
                            if (currentSnakeRow == burrowCordinates[0] &&
                                currentSnakeCol == burrowCordinates[1])
                            {
                                matrix[burrowCordinates[0], burrowCordinates[1]] = '.';
                                currentSnakeRow = burrowCordinates[2];
                                currentSnakeCol = burrowCordinates[3];
                                matrix[burrowCordinates[2], burrowCordinates[3]] = 'S';
                            }
                            else
                            {
                                currentSnakeRow = burrowCordinates[0];
                                currentSnakeCol = burrowCordinates[1];
                                matrix[burrowCordinates[0], burrowCordinates[1]] = 'S';
                                matrix[burrowCordinates[2], burrowCordinates[3]] = '.';
                            }
                            matrix[currentSnakeRow, currentSnakeCol] = 'S';
                        }
                    }
                }
                if (input.ToLower() == "right")
                {
                    matrix[currentSnakeRow, currentSnakeCol] = '.';
                    currentSnakeCol += 1;
                    if (currentSnakeCol > matrix.GetLength(1) - 1)
                    {
                        isOut = true;
                        break;
                    }
                    else
                    {
                       
                         if (matrix[currentSnakeRow, currentSnakeCol] == '*')
                        {
                            foodEaten++;
                            matrix[currentSnakeRow, currentSnakeCol] = 'S';
                            if (foodEaten >= 10)
                            {
                                break;
                            }
                        }
                        else if (matrix[currentSnakeRow, currentSnakeCol] == 'B')
                        {
                            if (currentSnakeRow == burrowCordinates[0] &&
                                currentSnakeCol == burrowCordinates[1])
                            {
                                matrix[burrowCordinates[0], burrowCordinates[1]] = '.';
                                currentSnakeRow = burrowCordinates[2];
                                currentSnakeCol = burrowCordinates[3];
                                matrix[burrowCordinates[2], burrowCordinates[3]] = 'S';
                            }
                            else
                            {
                                currentSnakeRow = burrowCordinates[0];
                                currentSnakeCol = burrowCordinates[1];
                                matrix[burrowCordinates[0], burrowCordinates[1]] = 'S';
                                matrix[burrowCordinates[2], burrowCordinates[3]] = '.';
                            }
                        }
                    }
                }
                if (input.ToLower() == "up")
                {
                    matrix[currentSnakeRow, currentSnakeCol] = '.';
                    currentSnakeRow -= 1;
                    if (currentSnakeRow < 0)
                    {
                        isOut = true;
                        break;
                    }
                    else
                    {
                        if (matrix[currentSnakeRow, currentSnakeCol] == '*')
                        {
                            foodEaten++;
                            matrix[currentSnakeRow, currentSnakeCol] = 'S';
                            if (foodEaten >= 10)
                            {
                                break;
                            }
                        }
                        else if (matrix[currentSnakeRow, currentSnakeCol] == 'B')
                        {
                            if (currentSnakeRow == burrowCordinates[0] &&
                                currentSnakeCol == burrowCordinates[1])
                            {
                                matrix[burrowCordinates[0], burrowCordinates[1]] = '.';
                                currentSnakeRow = burrowCordinates[2];
                                currentSnakeCol = burrowCordinates[3];
                                matrix[burrowCordinates[2], burrowCordinates[3]] = 'S';
                            }
                            else
                            {
                                currentSnakeRow = burrowCordinates[0];
                                currentSnakeCol = burrowCordinates[1];
                                matrix[burrowCordinates[0], burrowCordinates[1]] = 'S';
                                matrix[burrowCordinates[2], burrowCordinates[3]] = '.';
                            }
                        }
                    }
                }
                if (input.ToLower() == "down")
                {
                    matrix[currentSnakeRow, currentSnakeCol] = '.';
                    currentSnakeRow += 1;
                    if (currentSnakeRow > matrix.GetLength(1) - 1)
                    {
                        isOut = true;
                        break;
                    }
                    else
                    {
                         if (matrix[currentSnakeRow, currentSnakeCol] == '*')
                        {
                            foodEaten++;
                            matrix[currentSnakeRow, currentSnakeCol] = 'S';
                            if (foodEaten >= 10)
                            {
                                break;
                            }
                        }
                        else if (matrix[currentSnakeRow, currentSnakeCol] == 'B')
                        {
                            if (currentSnakeRow == burrowCordinates[0] &&
                                currentSnakeCol == burrowCordinates[1])
                            {
                                matrix[burrowCordinates[0], burrowCordinates[1]] = '.';
                                currentSnakeRow = burrowCordinates[2];
                                currentSnakeCol = burrowCordinates[3];
                                matrix[burrowCordinates[2], burrowCordinates[3]] = 'S';
                            }
                            else
                            {
                                currentSnakeRow = burrowCordinates[0];
                                currentSnakeCol = burrowCordinates[1];
                                matrix[burrowCordinates[0], burrowCordinates[1]] = 'S';
                                matrix[burrowCordinates[2], burrowCordinates[3]] = '.';
                            }

                            
                        }
                    }
                }

                matrix[currentSnakeRow, currentSnakeCol] = 'S';
                input = Console.ReadLine();
            }

            if (isOut == true)
            {
                Console.WriteLine("Game over!");
            }

            if (foodEaten >= 10)
            {
                Console.WriteLine($"You won! You fed the snake.");
            }

            Console.WriteLine($"Food eaten: {foodEaten}");

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
