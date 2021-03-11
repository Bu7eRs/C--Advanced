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
			Car car = new Car(double.Parse(carData[1]), double.Parse(carData[2]), double.Parse(carData[3]));

			var truckData = GetData(Console.ReadLine());
			Truck truck = new Truck(double.Parse(truckData[1]), double.Parse(truckData[2]), double.Parse(truckData[3]));

			var BusData = GetData(Console.ReadLine());
			Bus bus = new Bus(double.Parse(BusData[1]), double.Parse(BusData[2]), double.Parse(BusData[3]));

			bool isEmpty = false;

			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				var data = GetData(Console.ReadLine());
				var currMode = data[0].ToLower();
				var currVehicle = data[1].ToLower();
				var value = double.Parse(data[2]);
				if (currMode == "drive" || currMode == "driveempty")
				{
					if (currVehicle == "car")
					{
						car.Drive(value);
					}
					else if (currVehicle == "truck")
					{
						truck.Drive(value);
					}
					else if (currVehicle == "bus")
					{
						if (currMode == "driveempty")
						{
							isEmpty = true;
						}
						bus.Drive(isEmpty, value);
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
					else if (currVehicle == "bus")
					{
						bus.Refuel(value);
					}
					}
			}

			Console.WriteLine(car);
			Console.WriteLine(truck);
			Console.WriteLine(bus);

		}

		static string[] GetData(string input)
		{
			return input
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.ToArray();
			}
		}
	}
