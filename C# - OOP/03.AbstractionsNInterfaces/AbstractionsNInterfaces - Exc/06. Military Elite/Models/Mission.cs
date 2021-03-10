using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
	{
	public class Mission : Imission
		{
		public Mission (string codeName, MissionState state)
			{
			CodeName = codeName;
			State = state;
			}
		public string CodeName { get; }

		public MissionState State { get; private set; }

		public void CompleteMission ()
			{
			this.State = MissionState.Finished;
			}
		public override string ToString ()
			{
			return $"Code Name: {this.CodeName} State: {this.State}";
			}
		}
	}
