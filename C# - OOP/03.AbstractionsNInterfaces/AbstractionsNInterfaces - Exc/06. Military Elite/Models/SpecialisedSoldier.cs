using MilitaryElite.Contracts;
using MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
	{
	public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
		{
		protected SpecialisedSoldier (int id, string firstname, string lastname, decimal salary, Corps corps) 
			: base(id, firstname, lastname, salary)
			{
			Corps = corps;
			}

		public Corps Corps { get;  }


		public override string ToString ()
			{
			return base.ToString() + Environment.NewLine + $"Corps: {this.Corps}";
			}
		}
		}