using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ParkingLot
	{
	class Program
		{
		static void Main (string[] args)
		{
			var input = Console.ReadLine();
			var parking = new HashSet<string>();
			while (true)
			{
				if (input.ToLower() == "end")
				{
					if (parking.Count == 0)
					{
						Console.WriteLine("Parking Lot is Empty");
					}
					else
					{
						foreach (var car in parking)
						{
							Console.WriteLine(car);
						}
					}
					break;
				}
				var inputparams = Regex.Split(input, ", ");
				if (inputparams[0] == "IN")
				{
					parking.Add(inputparams[1]);
				}
				else if (inputparams[0] == "OUT")
				{
					parking.Remove(inputparams[1]);
				}
					input = Console.ReadLine();
			}

			
		}
		}
	}
