using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Vehicles.Solid
	{
	public class Car : Contracts.Vehicles

	{
		private double litersPerKm;
		public Car (double fuelquantity, double litersperKM, double tankCapacity)
			: base(fuelquantity,  litersperKM, tankCapacity)
			{

			}

		public override double LitersPerKM
		{
			get => this.litersPerKm;
			set
			{
				litersPerKm = value + 0.9;
			}
		}
		public override void Drive (double kilometers)
		{
			double requiredFuel = kilometers * litersPerKm;
			if (requiredFuel <= FuelQuantity)
			{
				FuelQuantity -= requiredFuel;
				Console.WriteLine($"Car travelled {kilometers} km");
			}
			else
			{
				Console.WriteLine($"Car needs refueling");
			}
		}

		public override string ToString()
		{
			 return $"Car: {this.FuelQuantity:f2}";
		}
	}
	}
