using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> Tasks = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Queue<int> Threads = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            int Task = int.Parse(Console.ReadLine());

            while (true)
            {
                int currTask = Tasks.Peek();
                int currThread = Threads.Peek();
                if (currTask == Task)
                {
                    Console.WriteLine($"Thread with value {currThread} killed task {Task}");
                    Console.WriteLine($"{string.Join(" ", Threads)}");
                    break;
                }
                if (currThread >= currTask)
                {
                    Tasks.Pop();
                    Threads.Dequeue();
                }
                else if(currThread < currTask)

                {
                    Threads.Dequeue();
                }
            }
        }
    }
}
