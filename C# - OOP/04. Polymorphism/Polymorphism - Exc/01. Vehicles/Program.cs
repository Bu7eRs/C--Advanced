using System;
using System.Linq;
using Vehicles.Solid;

namespace Vehicles
	{
	public class Program
		{
		static void Main (string[] args)
		{

			var carData = GetData(Console.ReadLine());
			Car car = new Car(double.Parse(carData[1]), double.Parse(carData[2]));

			var truckData = GetData(Console.ReadLine());
			Truck truck = new Truck(double.Parse(truckData[1]), double.Parse(truckData[2]));

			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				var data = GetData(Console.ReadLine());
				var currMode = data[0].ToLower();
				var currVehicle = data[1].ToLower();
				var value = double.Parse(data[2]);
				if (currMode == "drive")
				{
					if (currVehicle == "car")
					{
						car.Drive(value);
					}
					else if (currVehicle == "truck")
					{
						truck.Drive(value);
					}
				}
				else if (currMode == "refuel")
				{
					if (currVehicle == "car")
					{
						car.Refuel(value);
					}
					else if (currVehicle == "truck")
					{
						truck.Refuel(value);
					}
				}
			}

			Console.WriteLine(car);
			Console.WriteLine(truck);

		}

		static string[] GetData(string input)
		{
			return input
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.ToArray();
			}
		}
	}
