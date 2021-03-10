using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
	{
	public abstract class Soldier : Isoldier
		{

		protected Soldier (int id, string firstname, string lastname)
			{
			Id = id;
			FirstName = firstname;
			LastName = lastname;

			}
		public  int Id { get;  }
		public  string FirstName { get;  }
		public  string LastName { get;  }


		public override string ToString ()
			{
			return $"Name: {FirstName} {LastName} Id: {this.Id}";
			}
		}
	}
