using System;
using System.Collections.Generic;
using System.Text;
using PersonInfo.Contracts;

namespace PersonInfo
	{
		public class Citizen : IPerson, IBirthable, IIdentifiable

		{
		public string Name { get; set; }

		public int Age { get; set; }

		public Citizen(string name, int age, string id, string birhDate)
		{
			Name = name;
			Age = age;
			Birthdate = birhDate;
			Id = id;
		}

		public string Birthdate { get; set; }
		public string Id { get; set; }
		}
	}
