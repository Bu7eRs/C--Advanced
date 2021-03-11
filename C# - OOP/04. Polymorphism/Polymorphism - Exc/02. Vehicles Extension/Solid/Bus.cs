using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Vehicles.Solid
	{
	public class Bus : Contracts.Vehicles
		{
		public Bus (double fuelquantity, double litersperKM, double tankcapacity)
			: base(fuelquantity, litersperKM, tankcapacity)
			{
			}

		public override double LitersPerKM { get; set; }
		public override void Drive(bool isEmpty, double kilometers)
			{
			double FuelRequired = kilometers * LitersPerKM;
			if (!isEmpty)
				{
				FuelRequired = kilometers * (LitersPerKM + 1.4);
				}
			if (FuelRequired <= FuelQuantity)
				{
				FuelQuantity -= FuelRequired;
				Console.WriteLine($"Bus travelled {kilometers} km");
				}
			else
				{
				Console.WriteLine($"Bus needs refueling");
				}

			}

		public override string ToString()
		{
			return $"Bus: {FuelQuantity:f2}";
		}
		}
	}
