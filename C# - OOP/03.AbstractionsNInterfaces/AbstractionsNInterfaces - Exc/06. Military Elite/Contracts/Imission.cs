using MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Contracts
	{
	public interface Imission
		{
		string CodeName { get; }

		MissionState State { get; }

		void CompleteMission ();
		}
	}
