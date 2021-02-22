using System;

namespace Revolt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            int index = 0;

            char[,] matrix = new char[n, n];
            int[] Positions = new int[2];


            for (int Row = 0; Row < matrix.GetLength(0); Row++)
            {
                char[] input = Console.ReadLine()
                    .ToCharArray();

                for (int Col = 0; Col < matrix.GetLength(1); Col++)
                {
                    if (input[Col] != '-')
                    {
                        if (input[Col] == 'f')
                        {
                            Positions[0] = Row;
                            Positions[1] = Col;
                        }
                    }

                    matrix[Row, Col] = input[Col];
                }
            }


            int playerCurRow = Positions[0];
            int playerCurCol = Positions[1];


            string commands = Console.ReadLine();
            bool isWon = false;
            while (true)
            {
                index++;
                if (commands.ToLower() == "left")
                {
                    matrix[playerCurRow, playerCurCol] = '-';
                    playerCurCol -= 1;
                    if (playerCurCol < 0)
                    {
                        playerCurCol = matrix.GetLength(1) - 1;
                        
                    }
                    if (matrix[playerCurRow, playerCurCol] == '-')
                    {
                        matrix[playerCurRow, playerCurCol] = 'f';
                    }
                    else
                    {


                        if (matrix[playerCurRow, playerCurCol] == 'B')
                        {
                            playerCurCol -= 1;
                            if (playerCurCol < 0)
                            {
                                playerCurCol = matrix.GetLength(1) - 1;

                            }
                            matrix[playerCurRow, playerCurCol] = 'f';
                        }

                        if (matrix[playerCurRow, playerCurCol] == 'T')
                        {
                            playerCurCol += 1;
                            matrix[playerCurRow, playerCurCol] = 'f';
                        }
                        else if (matrix[playerCurRow, playerCurCol] == 'F')
                        {
                            isWon = true;
                            matrix[playerCurRow, playerCurCol] = 'f';
                            break;
                        }
                    }
                }
                else if (commands.ToLower() == "right")
                {
                    matrix[playerCurRow, playerCurCol] = '-';
                    playerCurCol += 1;
                    if (playerCurCol > matrix.GetLength(0) - 1)
                    {
                        playerCurCol = 0;
                        
                    }
                    if (matrix[playerCurRow, playerCurCol] == '-')
                    {
                        matrix[playerCurRow, playerCurCol] = 'f';
                    }
                    else
                    {
                        if (matrix[playerCurRow, playerCurCol] == 'B')
                        {
                            playerCurCol += 1;
                            if (playerCurCol > matrix.GetLength(0) - 1)
                            {
                                playerCurCol = 0;

                            }
                            matrix[playerCurRow, playerCurCol] = 'f';
                        }

                        if (matrix[playerCurRow, playerCurCol] == 'T')
                        {
                            playerCurCol -= 1;
                            matrix[playerCurRow, playerCurCol] = 'f';
                        }
                        else if (matrix[playerCurRow, playerCurCol] == 'F')
                        {
                            isWon = true;
                            matrix[playerCurRow, playerCurCol] = 'f';
                            break;
                        }
                    }
                }
                else if (commands.ToLower() == "up")
                {
                    matrix[playerCurRow, playerCurCol] = '-';
                    playerCurRow -= 1;
                    if (playerCurRow < 0)
                    {
                        playerCurRow = matrix.GetLength(1) - 1;
                    }

                    if (matrix[playerCurRow, playerCurCol] == '-')
                    {
                        matrix[playerCurRow, playerCurCol] = 'f';
                    }
                    else
                    {
                        if (matrix[playerCurRow, playerCurCol] == 'B')
                        {
                            playerCurRow -= 1;
                            if (playerCurRow < 0)
                            {
                                playerCurRow = matrix.GetLength(1) - 1;
                            }
                            matrix[playerCurRow, playerCurCol] = 'f';
                        }

                        if (matrix[playerCurRow, playerCurCol] == 'T')
                        {
                            playerCurRow += 1;
                            matrix[playerCurRow, playerCurCol] = 'f';
                        }
                        else if (matrix[playerCurRow, playerCurCol] == 'F')
                        {
                            isWon = true;
                            matrix[playerCurRow, playerCurCol] = 'f';
                            break;
                        }
                    }
                }
                else if (commands.ToLower() == "down")
                {
                    matrix[playerCurRow, playerCurCol] = '-';
                    playerCurRow += 1;
                    if (playerCurRow > matrix.GetLength(0) -1)
                    {
                        playerCurRow = 0;
                        
                    }
                    if (matrix[playerCurRow, playerCurCol] == '-')
                    {
                        matrix[playerCurRow, playerCurCol] = 'f';
                    }
                    else
                    {
                        
                            if (matrix[playerCurRow, playerCurCol] == 'B')
                            {
                                playerCurRow += 1;
                                if (playerCurRow > matrix.GetLength(0) - 1)
                                {
                                    playerCurRow = 0;

                                }
                            matrix[playerCurRow, playerCurCol] = 'f';
                            }

                            if (matrix[playerCurRow, playerCurCol] == 'T')
                            {
                                playerCurRow -= 1;
                                matrix[playerCurRow, playerCurCol] = 'f';
                            }
                            else if (matrix[playerCurRow, playerCurCol] == 'F')
                            {
                                isWon = true;
                                matrix[playerCurRow, playerCurCol] = 'f';
                                break;
                            }
                        
                    }
                
                }

                if (index >= count)
                {
                    break;
                }
                commands = Console.ReadLine();
            }

            if (isWon)
            {
                Console.WriteLine($"Player won!");
            }
            else
            {
                Console.WriteLine($"Player lost!");
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
