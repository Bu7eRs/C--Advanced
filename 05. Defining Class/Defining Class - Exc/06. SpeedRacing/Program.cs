using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] carData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string model = carData[0];
                double fuelAmount = double.Parse(carData[1]);
                double fuelConsumptionPerKm = double.Parse(carData[2]);

                Car currentCar = new Car
                {
                    Model = model,
                    FuelAmount = fuelAmount,
                    FuelConsumptionPerKilometer = fuelConsumptionPerKm
                };
                cars.Add(currentCar);
            }

            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                string[] commandData = command.Split(" ");
                string model = commandData[1];
                double distanceTraveld = double.Parse(commandData[2]);

                Car car = cars.FirstOrDefault(c => c.Model == model);
                bool isDrive = car.Drive(distanceTraveld);
                if ( isDrive == false)
                {
                    Console.WriteLine($"Insufficient fuel for the drive");
                }

                command = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}"); 
            }
        }
    }
}
