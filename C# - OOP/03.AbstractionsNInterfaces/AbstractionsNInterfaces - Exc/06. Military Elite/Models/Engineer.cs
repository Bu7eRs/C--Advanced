using MilitaryElite.Contracts;
using MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
	{
	public class Engineer : SpecialisedSoldier, IEngineer
		{
		private readonly List<IRepair> repairs;
		public Engineer (int id, string firstname, string lastname, decimal salary, Corps corps)
			: base(id, firstname, lastname, salary, corps)
			{

			}

		public IReadOnlyCollection<IRepair> Repairs => this.repairs.AsReadOnly();

		public void AddRepair (IRepair Repair)
			{
			this.repairs.Add(Repair);
			}

		public override string ToString ()
			{
			StringBuilder sb = new StringBuilder(0);
			sb.AppendLine(base.ToString())
				.AppendLine("Repairs:");
			foreach (IRepair item in this.repairs)
				{
				sb.AppendLine("  " + item);
				}
			return sb.ToString().Trim();

			}
		}
	}
