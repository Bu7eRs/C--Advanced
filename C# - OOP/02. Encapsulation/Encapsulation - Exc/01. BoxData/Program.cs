using System;

namespace BoxData
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            try
            {
                Box box = new Box(length, width, height);

                Console.WriteLine(box.SurfaceArea());
                Console.WriteLine(box.LateralArea());
                Console.WriteLine(box.Volume());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           

        }
    }
}
