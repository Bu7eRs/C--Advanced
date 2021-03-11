using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Contracts
	{
		public abstract class Vehicles
		{
			private double fuelQuantity;
			public Vehicles(double fuelquantity, double litersperKM, double tankcapacity)
			{
				TankCapacity = tankcapacity;
			FuelQuantity = fuelquantity;
				LitersPerKM = litersperKM;
				
			}



			public virtual double FuelQuantity
			{
				get => this.fuelQuantity;
				set
				{
					if (value > TankCapacity)
					{
						fuelQuantity = 0;
					}
					else
					{
						fuelQuantity = value;
					}
				}
			}

			public double TankCapacity { get; set; }
			public virtual double LitersPerKM { get; set; }

			public virtual void Drive(double kilometers)
			{

			}

			public virtual void Drive(bool isEmpty, double value)
			{

			}
			public virtual void Refuel(double value)
			{
				if (value <= 0)
				{
					Console.WriteLine($"Fuel must be a positive number");
				}
				else if (value >= TankCapacity - FuelQuantity)
				{
					Console.WriteLine($"Cannot fit {value} fuel in the tank");
				}
				else
				{
					FuelQuantity += value;
				}
			}
		


		}
	}
