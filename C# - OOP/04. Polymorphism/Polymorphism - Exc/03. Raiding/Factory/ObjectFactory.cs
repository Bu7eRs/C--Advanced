using System;
using System.Collections.Generic;
using System.Text;
using Raiding;
using Raiding.Enum;
using Raiding.Solid;

namespace Riding.Factory
	{
		public static class ObjectFactory
		{
			public static BaseHero Create(string heroName, string heroRole)
			{
				BaseHero currHero = null;
				
					if (heroRole.ToLower() == "paladin")
					{
						 currHero = new Paladin(heroName);
					}
					else if (heroRole.ToLower() == "warrior")
					{
						 currHero = new Warrior(heroName);
					}
					else if (heroRole.ToLower() == "druid")
					{
						 currHero = new Druid(heroName);
					}
					else if (heroRole.ToLower() == "rogue")
					{
						 currHero = new Rogue(heroName);
					}
					else
				{
					Console.WriteLine($"Invalid hero!");
				}

					return currHero;

			}
		}
	}
	
