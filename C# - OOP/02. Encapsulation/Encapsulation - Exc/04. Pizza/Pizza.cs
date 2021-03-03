using System;
using System.Buffers;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Pizza
{
    class Pizza
    {

        private const int maxValueLenght = 15;
        private const int minValueLenght = 1;
        private const int maxTopicCount = 10; 

        private string name;

        private readonly List<Topping> toppings;

        private Dough dough;

        public Pizza(string name)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < minValueLenght ||value.Length > maxValueLenght)
                {
                    throw new ArgumentException($"Pizza name should be between {minValueLenght} and {maxValueLenght} symbols.");
                }
                this.name = value;
            }
        }

         
        public Dough Dough
        {
            get { return this.dough; }
            set { this.dough = value; }
        }

        public int CountOfTopings => this.toppings.Count;

        public double TotalCalories => CalculateTotalCalories();

        public void AddTopping(Topping toppings)
        {
            if (this.toppings.Count == maxTopicCount)
            {
                throw new ArgumentException($"Number of toppings should be in range [0..{maxTopicCount}].");
            }
        }

        private double CalculateTotalCalories()
        {
            double result = this.dough.TotalCalories;

            foreach (var topping in this.toppings)
            {
                result += topping.TotalCalories;
            }


            return result;
        }
    }
}
