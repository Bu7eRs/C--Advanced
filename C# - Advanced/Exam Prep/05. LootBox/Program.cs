using System;
using System.Collections.Generic;
using System.Linq;

namespace LootBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Stack<int> secondBox = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int sum = 0;
            while (true)
            {
                int firstCurrNumber = firstBox.Peek();
                int secondCurrNumber = secondBox.Peek();

                if ((firstCurrNumber + secondCurrNumber) % 2 == 0)
                {
                    sum += firstBox.Dequeue();
                    sum += secondBox.Pop();
                }
                else
                {
                    firstBox.Enqueue(secondBox.Pop());
                }

                if (firstBox.Count <= 0)
                {
                    Console.WriteLine("First lootbox is empty");
                    break;
                }

                if (secondBox.Count <= 0)
                {
                    Console.WriteLine($"Second lootbox is empty");
                    break;
                }
            }

            if (sum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sum}");
            }
        }
    }
}
