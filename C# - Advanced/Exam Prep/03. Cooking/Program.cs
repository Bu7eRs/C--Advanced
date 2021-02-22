using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> Liquids = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());
            Stack<int> Ingredients = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            int cookedBread = 0;
            int cookedCake = 0;
            int cookedPastry = 0;
            int cookedFruitPie = 0;
            int bread = 25;
            int cake = 50;
            int pastry = 75;
            int fruitPie = 100;
            while (true)
            {
                int currLiquid = Liquids.Peek();
                int currIngredient = Ingredients.Peek();


                if (currIngredient + currLiquid == bread)
                {
                    Liquids.Dequeue();
                    Ingredients.Pop();
                    cookedBread++;
                }
                else if (currIngredient + currLiquid == cake)
                {
                    Liquids.Dequeue();
                    Ingredients.Pop();
                    cookedCake++;
                }
                else if (currIngredient + currLiquid == pastry)
                {
                    Liquids.Dequeue();
                    Ingredients.Pop();
                    cookedPastry++;
                }
                else if (currIngredient + currLiquid == fruitPie)
                {
                    Liquids.Dequeue();
                    Ingredients.Pop();
                    cookedFruitPie++;
                }
                else
                {
                    Liquids.Dequeue();

                    var save = Ingredients.Pop() + 3;
                    List<int> holder = new List<int>(Ingredients);
                    Ingredients.Clear();
                    holder.Reverse();
                    holder.Add(save);
                    foreach (var i in holder)
                    {
                        Ingredients.Push(i);
                    }
                }

                if (Liquids.Count <= 0 || Ingredients.Count <= 0)
                {
                    if (cookedBread > 0 && cookedCake > 0
                                        && cookedFruitPie > 0 && cookedPastry > 0)
                    {
                        Console.WriteLine($"Wohoo! You succeeded in cooking all the food!");
                    }
                    else
                    {
                        Console.WriteLine($"Ugh, what a pity! You didn't have enough materials to cook everything.");
                    }

                    if (Liquids.Count <= 0)
                    {
                        Console.WriteLine($"Liquids left: none");
                    }
                    else
                    {

                        Console.WriteLine($"Liquids left: {string.Join(", ", Liquids)} ");
                    }

                    if (Ingredients.Count <= 0)
                    {
                        Console.WriteLine($"Ingredients left: none");
                    }
                    else
                    {
                        Console.WriteLine($"Ingredients left: {string.Join(", ", Ingredients)}");
                    }

                    Console.WriteLine($"Bread: {cookedBread}");
                    Console.WriteLine($"Cake: {cookedCake}");
                    Console.WriteLine($"Fruit Pie: {cookedFruitPie}");
                    Console.WriteLine($"Pastry: {cookedPastry}");
                    break;
                }
            }

        }


    }
}
