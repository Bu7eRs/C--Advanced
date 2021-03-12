using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Solid
	{
	public class Druid:BaseHero
		{
			public Druid(string name) 
				: base(name)
			{
			}

			public override int Power { get; set; } = 80;
			public override string CastAbility()
			{
				return $"Druid - {this.Name} hit for {this.Power} damage";
			}
		}
	}
