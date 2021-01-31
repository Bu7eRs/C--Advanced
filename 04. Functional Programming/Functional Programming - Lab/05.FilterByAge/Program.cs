using System;

namespace FilterByAge
	{
	class persons
		{
		public string name { get; set; }
		public int age { get; set; }

		}

	class Program
		{
		static void Main (string[] args)
			{
			int n = int.Parse(Console.ReadLine());
			persons[] people = new persons[n];

			for (int i = 0; i < n; i++)
				{
				var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
				people[i] = new persons();
				people[i].name = input[0];
				people[i].age = int.Parse(input[1]);
				}

			string filter = Console.ReadLine();
			int filterAge = int.Parse(Console.ReadLine());
			Func<persons, bool> condition = GetAgeCondition(filter, filterAge);
			Func<persons, string> formatter = GetFormatter(Console.ReadLine());
			printpeople(people, condition, formatter);
			}
		static Func<persons, bool> GetAgeCondition (string filter, int filterAge)
			{
			switch (filter)
				{

				case "younger": return p => p.age < filterAge;
				case "older": return p => p.age >= filterAge;
				default:
					return null;
				}
			}

		static Func<persons, string> GetFormatter(string format)
		{
			switch (format)
			{
				case "name": return p => $"{p.name}";
				case "age": return p => $"{p.age}";
				case "name age": return p => $"{p.name} - {p.age}";
				default:
					return null;
			}
		}
		static void printpeople (persons[] people,
					Func<persons, bool> condition, Func<persons, string> formatter)
		{
			foreach (var person in people)
				{
				if (condition(person))
					{
					Console.WriteLine(formatter(person));
					}
				}
			}
		}

	}
