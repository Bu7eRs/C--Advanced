using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
	{
	public class Spy : Soldier, Ispy
		{
		public Spy (int id, string firstname, string lastname, int codenumber) 
			: base(id, firstname, lastname)
			{
				CodeNumber = codenumber;
			}

		public int CodeNumber { get; }

		public override string ToString ()
			{
			return base.ToString() + Environment.NewLine + $"Code number: {this.CodeNumber}";
			}
		}
	}
