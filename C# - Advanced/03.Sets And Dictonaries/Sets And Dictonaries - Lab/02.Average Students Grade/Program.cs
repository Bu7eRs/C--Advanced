using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentsGrade
	{
	class Program
		{
		static void Main (string[] args)
		{
			int numOfStudents = int.Parse(Console.ReadLine());
			Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();
			for (int i = 0; i < numOfStudents; i++)
			{
				string[] input = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.ToArray();
				string name = input[0];
				double currentGrade = double.Parse(input[1]);
				if (grades.ContainsKey(name))
				{
					  grades[name].Add(currentGrade);
				}
				else
				{
					grades.Add(name, new List<double>());
					grades[name].Add(currentGrade);
				}
			}

			foreach (var grade in grades)
			{
				
					Console.Write($"{grade.Key} -> ");
					foreach (var value in grade.Value)
					{
						Console.Write($"{value:f2} ");
					}

					Console.WriteLine($"(avg: {grade.Value.Average():f2})");
				}
		}
		}
	}
