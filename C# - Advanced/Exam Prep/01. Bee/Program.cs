using System;
using System.Threading.Channels;

namespace Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            int BeeRowPos = 0;
            int BeeColPos = 0;
            int flowersCollection = 0;
            bool isOut = false;
            for (int Row = 0; Row < matrix.GetLength(0); Row++)
            {
                string input = Console.ReadLine();
                char[] charrArr = input.ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (charrArr[col] == 'B')
                    {
                        BeeRowPos = Row;
                        BeeColPos = col;
                    }
                    matrix[Row, col] = charrArr[col];
                } 
            }

            string direction = Console.ReadLine();
            while (true)
            {
                int rowDimensions = matrix.GetLength(0) -1;
                int colDimensions = matrix.GetLength(1) -1 ;
                if (direction.ToLower() == "end")
                {
                    break;
                }

                if (direction.ToLower() == "left")
                {
                    matrix[BeeRowPos, BeeColPos] = '.';
                    if (BeeColPos - 1 < 0)
                    {
                        isOut = true;
                        break;
                    }

                    else
                    {
                        BeeColPos -= 1;
                        if (matrix[BeeRowPos, BeeColPos] == 'O')
                        {
                            matrix[BeeRowPos, BeeColPos] = '.';
                            BeeColPos -= 1;
                            if (BeeColPos < 0)
                            {
                                isOut = true;
                                break;
                            }
                        }

                        if (matrix[BeeRowPos, BeeColPos] == 'f')
                        {
                            
                            flowersCollection++;
                        }

                        matrix[BeeRowPos, BeeColPos] = 'B';
                    }
                    
                }
                if (direction.ToLower() == "right")
                {
                    matrix[BeeRowPos, BeeColPos] = '.';
                    if (BeeColPos + 1 >colDimensions)
                    {
                        isOut = true;
                        break;
                    }
                    else
                    {
                        BeeColPos += 1;
                        if (matrix[BeeRowPos, BeeColPos] == 'O')
                        {
                            matrix[BeeRowPos, BeeColPos] = '.';
                            BeeColPos += 1;
                            if (BeeColPos > colDimensions)
                            {
                                isOut = true;
                                break;
                            }
                        }

                        if (matrix[BeeRowPos, BeeColPos] == 'f')
                        {
                            flowersCollection++;
                        }

                        matrix[BeeRowPos, BeeColPos] = 'B';
                    }

                }
                if (direction.ToLower() == "up")
                {
                    matrix[BeeRowPos, BeeColPos] = '.';
                    if (BeeRowPos - 1 < 0)
                    {
                        isOut = true;
                        break;
                    }
                    else
                    {
                        BeeRowPos -= 1;
                        if (matrix[BeeRowPos, BeeColPos] == 'O')
                        {
                            matrix[BeeRowPos, BeeColPos] = '.';
                            BeeRowPos -= 1;
                            if (BeeColPos < 0)
                            {
                                isOut = true;
                                break;
                            }
                        }

                        if (matrix[BeeRowPos, BeeColPos] == 'f')
                        {
                            flowersCollection++;
                        }

                        matrix[BeeRowPos, BeeColPos] = 'B';
                    }

                }
                if (direction.ToLower() == "down")
                {
                    matrix[BeeRowPos, BeeColPos] = '.';
                    if (BeeRowPos + 1 > rowDimensions)
                    {
                        isOut = true;
                        break;
                    }
                    else
                    {
                        BeeRowPos += 1;
                        if (matrix[BeeRowPos, BeeColPos] == 'O')
                        {
                            matrix[BeeRowPos, BeeColPos] = '.';
                            BeeRowPos += 1;
                            if (BeeColPos > rowDimensions)
                            {
                                isOut = true;
                                break;
                            }
                        }

                        if (matrix[BeeRowPos, BeeColPos] == 'f')
                        {
                            flowersCollection++;
                        }

                        matrix[BeeRowPos, BeeColPos] = 'B';
                    }

                }
                direction = Console.ReadLine();

            }

            if (isOut == true)
            {
                Console.WriteLine($"The bee got lost!");
            }

            if (flowersCollection < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers," +
                                  $" she needed {5 - flowersCollection} flowers more");
            }
            else {
                Console.WriteLine($"Great job, the bee managed to pollinate " +
                                  $"{flowersCollection} flowers!");}
            for (int Row = 0; Row < matrix.GetLength(0); Row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[Row,col]);
                }

                Console.WriteLine();
            }
        }
    }
}
