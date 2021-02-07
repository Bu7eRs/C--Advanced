using System;

namespace DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string SecondDate = Console.ReadLine();

            int days = DateModifier.GetDifferenceBetweenDates(firstDate, SecondDate);
            Console.WriteLine(Math.Abs(days));
        }
    }
}
