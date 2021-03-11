using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Solid
	{
	public class Truck: Contracts.Vehicles
	{
		private double litersPerKm;

			public Truck(double fuelquantity, double litersperKM, double tankcapacity)
				: base(fuelquantity,  litersperKM, tankcapacity)
			{
			}


			public override double LitersPerKM
			{
				get => this.litersPerKm;
				set
				{
					litersPerKm = value + 1.6;
				}
			}
		public override void Drive (double kilometers)
		{
			double requiredFuel = kilometers * litersPerKm;
			if (requiredFuel <= FuelQuantity)
			{
				FuelQuantity -= requiredFuel;
				Console.WriteLine($"Truck travelled {kilometers} km");
			}
			else
			{
				Console.WriteLine($"Truck needs refueling");
			}
			}


		public override string ToString()
		{
			return $"Truck: {this.FuelQuantity:f2}";
		}
	}
	}
