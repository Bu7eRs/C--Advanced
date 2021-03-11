using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Solid
	{
	public class Truck: Contracts.Vehicles
	{
		private double litersPerKm;

		private double fuelQuantity;
			public Truck(double fuelquantity, double litersperKM)
				: base(fuelquantity,  litersperKM)
			{
				FuelQuantity = fuelquantity;
				LitersPerKM = litersperKM;
			}

			public override double FuelQuantity { get; set; }

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

		public override void Refuel(double value)
			{
				this.FuelQuantity += (value * 0.95);
			}

		public override string ToString()
		{
			return $"Truck: {this.FuelQuantity:f2}";
		}
	}
	}
