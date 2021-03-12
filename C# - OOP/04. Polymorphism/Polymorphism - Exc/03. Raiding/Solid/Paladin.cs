using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Solid
	{
	public class Paladin :BaseHero
		{
			public Paladin(string name)
				: base(name)
			{
			}

			public override int Power { get; set; } = 100;
			public override string CastAbility()
			{
				return $"Paladin - {this.Name} hit for {this.Power} damage";
			}
		}
	}
