using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace BoxData
{
   public class Box
   {

       private double length;
       private double width;
       private double height;


       public Box(double length, double width, double height)
       {
           this.Length = length;
           this.Width = width;
           this.Height = height;
       }

       public double Length
       {
           get
           {
               return this.length;
           }
           private set
           {
               if (value <= 0)
               {
                   throw new ArgumentException($"Length cannot be zero or negative.");
               }
               this.length = value;
           }
       }


        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Height cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public  double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }


        public string SurfaceArea()
        {
            double sum = 2 * ((this.length * this.width) + (this.length * this.height) + (this.width * this.height));
            return $"Surface Area - {sum:f2}";
        }  
        public  string LateralArea()
        {
            double sum = 2 * ((this.length * this.height) + (this.width * this.height));
            return $"Lateral Surface Area - {sum:f2}";
        }
        public  string Volume()
        {
            double sum = this.length * this.width * this.height;
            return $"Volume - {sum:f2}";
        }


    }
}
