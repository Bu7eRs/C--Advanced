using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Solid
	{
	public class Warrior: BaseHero
		{
			public Warrior(string name) 
				: base(name)
			{
			}

			public override int Power { get; set; } = 100;
			public override string CastAbility()
			{
				return $"Warrior - {this.Name} hit for {Power} damage";
			}
		}
	}
