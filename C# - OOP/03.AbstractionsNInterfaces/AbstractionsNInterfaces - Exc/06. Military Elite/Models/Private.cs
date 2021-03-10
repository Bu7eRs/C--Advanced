using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
	{
	public class Private : Soldier, IPrivate
		{
		public Private (int id, string firstname, string lastname, decimal salary) 
			: base(id, firstname, lastname)
			{
			this.Salary = salary;
			}

		public decimal Salary { get; }

		public override string ToString ()
			{
			return base.ToString() + $" Salary: {this.Salary}";
			}
		}
	}
