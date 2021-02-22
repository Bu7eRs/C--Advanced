using System;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int[] Pillar = new int[6];
            int[] FirstSPos = new int[4];
            int pillarCount = 0;
            int Money = 0;
            for (int Row = 0; Row < matrix.GetLength(0); Row++)
            {
                char[] matrixData = Console.ReadLine().ToCharArray();

                for (int Col = 0; Col < matrix.GetLength(1); Col++)
                {
                    if (matrixData[Col] == 'O')
                    {
                        Pillar[pillarCount] = Row;
                        pillarCount++;
                        Pillar[pillarCount] = Col;
                        pillarCount++;
                    }
                    else if (matrixData[Col] == 'S')
                    {
                        FirstSPos[0] = Row;
                        FirstSPos[1] = Col;
                    }

                    matrix[Row, Col] = matrixData[Col];
                }

            }
            int currSRowPos = FirstSPos[0];
            int currSColPos = FirstSPos[1];
            int firstPillarRow = Pillar[0];
            int firstPillarCol = Pillar[1];
            int secondPillarRow = Pillar[2];
            int secondPillarCol = Pillar[3];
            string input = Console.ReadLine();
            bool IsOut = false;
            while (true)
            {


                if (input.ToLower() == "end")
                {
                    break;
                }

                if (input.ToLower() == "left")
                {
                    matrix[currSRowPos, currSColPos] = '-';
                    currSColPos -= 1;
                    if (currSColPos < 0)
                    {
                        IsOut = true;
                        break;
                    }
                    else if (char.IsDigit(matrix[currSRowPos, currSColPos]))
                    {
                        int currMoney = int.Parse(matrix[currSRowPos, currSColPos].ToString());
                        Money += currMoney;
                        matrix[currSRowPos, currSColPos] = 'S';
                    }
                    else if (matrix[currSRowPos, currSColPos] == 'O')

                    {
                        matrix[currSRowPos, currSColPos] = '-';
                        if (currSRowPos + currSColPos == firstPillarCol + firstPillarRow)
                        {
                            currSColPos = secondPillarCol;
                            currSRowPos = secondPillarRow;
                            matrix[currSRowPos, currSColPos] = 'S';
                        }

                        else

                        {
                            currSRowPos = firstPillarRow;
                            currSColPos = firstPillarCol;
                            matrix[currSRowPos, currSColPos] = 'S';
                        }
                    }
                }
                else if (input.ToLower() == "right")
                {
                    matrix[currSRowPos, currSColPos] = '-';
                    currSColPos += 1;
                    if (currSColPos > matrix.GetLength(1) - 1)
                    {
                        IsOut = true;
                        break;
                    }
                    else if (char.IsDigit(matrix[currSRowPos, currSColPos]))
                    {
                        int currMoney = int.Parse(matrix[currSRowPos, currSColPos].ToString());
                        Money += currMoney;
                        matrix[currSRowPos, currSColPos] = 'S';
                    }
                    else if (matrix[currSRowPos, currSColPos] == 'O')

                    {
                        matrix[currSRowPos, currSColPos] = '-';
                        if (currSRowPos + currSColPos == firstPillarCol + firstPillarRow)
                        {
                            currSColPos = secondPillarCol;
                            currSRowPos = secondPillarRow;
                            matrix[currSRowPos, currSColPos] = 'S';
                        }

                        else

                        {
                            currSRowPos = firstPillarRow;
                            currSColPos = firstPillarCol;
                            matrix[currSRowPos, currSColPos] = 'S';
                        }
                    }
                }
                else if (input.ToLower() == "down")
                {
                    matrix[currSRowPos, currSColPos] = '-';
                    currSRowPos += 1;
                    if (currSRowPos > matrix.GetLength(0) - 1 )
                    {
                        IsOut = true;
                        break;
                    }
                    else if (char.IsDigit(matrix[currSRowPos, currSColPos]))
                    {
                        int currMoney = int.Parse(matrix[currSRowPos, currSColPos].ToString());
                        Money += currMoney;
                        matrix[currSRowPos, currSColPos] = 'S';
                    }
                    else if (matrix[currSRowPos, currSColPos] == 'O')

                    {
                        matrix[currSRowPos, currSColPos] = '-';
                        if (currSRowPos + currSColPos == firstPillarCol + firstPillarRow)
                        {
                            currSColPos = secondPillarCol;
                            currSRowPos = secondPillarRow;
                            matrix[currSRowPos, currSColPos] = 'S';
                        }

                        else

                        {
                            currSRowPos = firstPillarRow;
                            currSColPos = firstPillarCol;
                            matrix[currSRowPos, currSColPos] = 'S';
                        }
                    }
                }
                else if (input.ToLower() == "up")
                {
                    matrix[currSRowPos, currSColPos] = '-';
                    currSRowPos -= 1;
                    if (currSRowPos < 0)
                    {
                        IsOut = true;
                        break;
                    }
                    else if (char.IsDigit(matrix[currSRowPos, currSColPos]))
                    {
                        int currMoney = int.Parse(matrix[currSRowPos, currSColPos].ToString());
                        Money += currMoney;
                        matrix[currSRowPos, currSColPos] = 'S';

                    }
                    else if (matrix[currSRowPos, currSColPos] == 'O')

                    {
                        matrix[currSRowPos, currSColPos] = '-';
                        if (currSRowPos + currSColPos == firstPillarCol + firstPillarRow)
                        {
                            currSColPos = secondPillarCol;
                            currSRowPos = secondPillarRow;
                            matrix[currSRowPos, currSColPos] = 'S';
                        }

                        else

                        {
                            currSRowPos = firstPillarRow;
                            currSColPos = firstPillarCol;
                            matrix[currSRowPos, currSColPos] = 'S';
                        }
                    }
                }

                if (Money >= 50)
                {
                    break;

                }
                input = Console.ReadLine();
            }

            if (IsOut == true)
            {
                Console.WriteLine($"Bad news, you are out of the bakery.");
            }

            if (Money >= 50)
            {
                Console.WriteLine($"Good news! You succeeded in collecting enough money!");
            }

            Console.WriteLine($"Money: {Money}");

            for (int Row = 0; Row < matrix.GetLength(0); Row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[Row, col]);
                }

                Console.WriteLine();
            }

        }
    }
}
