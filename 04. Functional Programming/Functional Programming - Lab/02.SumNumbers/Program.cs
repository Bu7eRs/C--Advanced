using System;
using System.Linq;

namespace FunctionalProgramming
	{
	class Program
		{
		static void Main (string[] args)
		{
			PrintSumAndCount(x => int.Parse(x), a => a.Length, array => array.Sum());
		}

		static void PrintSumAndCount(Func<string, int> parser,
			Func<int[], int> CountGetter,
			Func<int[], int> SumCalc)
		{
			int[] array =
				Console.ReadLine()
					.Split(", ", StringSplitOptions.RemoveEmptyEntries)
					.Select(parser)
					.ToArray();
			Console.WriteLine(CountGetter(array));
			Console.WriteLine(SumCalc(array));

			}
		}
	}
