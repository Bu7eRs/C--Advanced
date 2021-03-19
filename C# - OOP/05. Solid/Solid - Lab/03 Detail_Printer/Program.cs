using System;
using System.Collections.Generic;
using P03.Detail_Printer;

namespace P03.DetailPrinter
{
    class Program
    {
        static void Main()
        {
	        IPrintable manager = new Manager("Pesho", new List<string>
	        {
                "document 1",
                "document 2",
                "document 3",
	        });
	        Console.WriteLine(manager.Print());
	        
        }
    }
}
