using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            Horsepower = horsePower;
            Fuel = fuel;
        }

        public virtual double DefaultFuelConsumption { get; set; } = 1.25;
        

        public double FuelConsumption { get; set; }

        public double Fuel { get; set; }

        public int Horsepower { get; set; }



        public virtual void Drive(double kilometers)
        {
            Fuel -= DefaultFuelConsumption * kilometers;
        }
    }
}
