using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Contracts
	{
		public abstract class Vehicles
		{
			public Vehicles(double fuelquantity, double litersperKM)
			{
				FuelQuantity = fuelquantity;
				LitersPerKM = litersperKM;
			}

			public virtual double FuelQuantity { get; set; }


			public abstract double LitersPerKM { get; set; }

			public abstract void Drive(double kilometers);

			public abstract void Refuel(double value);

		}
	}
