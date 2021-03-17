using System;

namespace P02.Graphic_Editor
{
    class Program
    {
        static void Main()
        {

	        DrawObjects GetObject = new DrawObjects(new Line());
	        Console.WriteLine(GetObject.DrawShape());
        }
    }
}
