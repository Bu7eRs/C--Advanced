using MilitaryElite.Contracts;
using MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
	{
	public class Comando : SpecialisedSoldier, ICommando
		{
		private readonly List<Imission> missions;
		public Comando (int id, string firstname, string lastname, decimal salary, Corps corps) 
			: base(id, firstname, lastname, salary, corps)
			{
			this.missions = new List<Imission>();
			}

		public IReadOnlyCollection<Imission> Missions => this.missions.AsReadOnly(); 

		public void AddMission (Imission mission)
			{
			this.missions.Add(mission);
			}

		public override string ToString ()
			{
			StringBuilder sb = new StringBuilder(0);
			sb.AppendLine(base.ToString())
				.AppendLine("Missions:");
			foreach (Imission item in this.missions)
				{
				sb.AppendLine("  " + item);
				}
			return sb.ToString().Trim();

			}
		}
	}
	