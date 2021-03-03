using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    public class Dough
    {

        private const double baseCaloriesPerGram = 2;

        private double grams;

        private const double minimalGrams = 1;

        private const double maximalGrams = 200;


        private readonly Dictionary<string, double> DefaultFlourTypes = new Dictionary<string, double>
        {
            {"white",  1.5},
            {"wholegrain", 1.0 }
        };

        private readonly Dictionary<string, double> DefaultBakingTechnique = new Dictionary<string, double>
        {
            {"crispy",  0.9},
            {"chewy", 1.1 },
            {"homemade", 1.0 }
        };

        private string flourType;

        private string bakingTechnique;


        public Dough(string flourType, string bakingTechnique, double grams)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Grams = grams;
        }

        public string FlourType
        {
            get { return this.flourType; }
            set
            {
                if (!this.DefaultFlourTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid flour type");
                }

                this.flourType = value.ToLower();
            }
        }


        public string BakingTechnique
        {
            get { return this.bakingTechnique; }
            set
            {
                if (!this.DefaultBakingTechnique.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value.ToLower();
            }
        }

    

        public double  Grams
        {
            get { return this.grams; }
            set
            {
                if (value < minimalGrams || value > maximalGrams)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{minimalGrams}..{maximalGrams}].");
                }
                this.grams = value;
            }
        }

        public double CaloriesPerGram => baseCaloriesPerGram *
                                         this.DefaultFlourTypes[this.flourType] * 
                                         this.DefaultBakingTechnique[this.bakingTechnique];

        public double TotalCalories => this.CaloriesPerGram * this.Grams;
    }
}
