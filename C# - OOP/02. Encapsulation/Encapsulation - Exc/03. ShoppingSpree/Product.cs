using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;

        private double cost;
        public Product(string name)
        {
            Name = name;
        }
        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!value.All(char.IsLetter))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public double Cost {

            get
            {
                return cost;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.cost = value;
            }
        }

        

        public static Product AddProduct(string data)
        {
            string[] input = data
                .Split("=", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Product currProduct = new Product(input[0]);
            currProduct.Cost = double.Parse(input[1]);
            return currProduct;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
