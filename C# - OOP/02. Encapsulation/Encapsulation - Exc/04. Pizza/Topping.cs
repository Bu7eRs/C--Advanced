using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
   public  class Topping
   {
       private const double baseCaloriesPerGram = 2;

       private const double MinGrams = 1;

       private const double MaxGrams = 50;

       private readonly Dictionary<string, double> defaultTypes = new Dictionary<string, double>
       {
           {"meat", 1.2 },
           {"veggies", 0.8 },
           {"cheese", 1.1 },
           {"sauce", 0.9 }
   };
        private string type;

        private double weight;

        public Topping(string name, double weight)
        {
            this.Type = name;
            this.Weight = weight;
        }

        public string Type
        {
            get { return this.type; }
            set
            {
                if (!this.defaultTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.type = value;
            }
        }


        public double Weight
        {
            get { return this.weight; }
            set
            {
                if (value < MinGrams || value > MaxGrams)
                {
                    throw new ArgumentException($"{value} weight should be in the range[{MinGrams}..{MaxGrams}].");
                }
                
                this.weight = value;
            }
        }

        public double CaloriesPerGram => baseCaloriesPerGram * this.defaultTypes[this.type];

        public double TotalCalories => this.CaloriesPerGram * this.weight;

   }
}
