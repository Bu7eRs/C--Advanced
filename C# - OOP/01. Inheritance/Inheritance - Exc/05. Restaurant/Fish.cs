using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Restaurant
{
    public class Fish : MainDish
    {
        private const double Grams = 22;
        public Fish(string name, decimal price)
            : base(name, price, Grams)
        {
        }

    }
}
