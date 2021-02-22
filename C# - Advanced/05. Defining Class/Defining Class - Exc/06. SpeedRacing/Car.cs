using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }


        public bool Drive(double distanceTraveled)
        {
            double neededFuel = distanceTraveled * 
                                FuelConsumptionPerKilometer;

            if (neededFuel > this.FuelAmount)
            {
                return false;

            }

            this.TravelledDistance += distanceTraveled;
            this.FuelAmount -= neededFuel;
                return true;
            
        }
    }
}
