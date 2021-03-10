using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
	{
	public class Repair : IRepair
		{

		public Repair (string partname, int hoursworked)
			{
			partname = partname;
			HoursWorked = hoursworked;

			}
		public string PartName { get; }

		public int HoursWorked  { get; }

		public override string ToString ()
			{
			return $"Part name: {this.PartName} Hours worked: {this.HoursWorked}";
			}
		}
	}
