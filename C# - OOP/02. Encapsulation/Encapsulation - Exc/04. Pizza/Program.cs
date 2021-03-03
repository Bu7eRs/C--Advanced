using System;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pizzaAargs = Console.ReadLine().Split();

            Pizza pizza = new Pizza(pizzaAargs[0]);

            string[] doughArgs = Console.ReadLine().Split();

            Dough dough = new Dough(doughArgs[1], doughArgs[2], double.Parse(doughArgs[3]));

            pizza.Dough = dough;

            string toppingInput = Console.ReadLine();

            while (toppingInput.ToLower() != "end")
            {
                string[] toppingArgs = Console.ReadLine().Split();

                Topping topping = new Topping(toppingArgs[1], double.Parse(toppingArgs[2]));
                pizza.AddTopping(topping);
                toppingInput = Console.ReadLine();
            }

            Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories.");
        }
    }
}
