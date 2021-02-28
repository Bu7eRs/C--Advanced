using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;

        private double money;

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            Products = new List<Product>();
            
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

        public double Money
        {
            get
            {
                return money;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public List<Product> Products { get; set; }

      
        public static Person AddPerson(string data)
        {
            string[] input = data
                .Split("=", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Person currPerson = new Person(input[0], double.Parse(input[1]));
            return currPerson;
        }

     
    }
}
