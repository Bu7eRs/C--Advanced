﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Contracts
	{
	public interface ICommando : ISpecialisedSoldier
		{
			IReadOnlyCollection<Imission> Missions { get; }

		void AddMission (Imission mission);
		}
	}
