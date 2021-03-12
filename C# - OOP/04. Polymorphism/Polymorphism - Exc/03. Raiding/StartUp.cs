using System;
using System.Collections.Generic;
using System.Linq;
using Raiding.Enum;
using Raiding.Solid;
using Riding.Factory;

namespace Raiding
	{
		class StartUp
		{
			static void Main(string[] args)
			{
				List<BaseHero> heroes = new List<BaseHero>();

				int n = int.Parse(Console.ReadLine());

				for (int i = 0; i < n; i++)
				{
					string currHeroName = Console.ReadLine();
					string currHeroRole = Console.ReadLine();
					BaseHero newHero = ObjectFactory.Create(currHeroName, currHeroRole);
					if (newHero != null)
					{
						heroes.Add(newHero);
					}
				}

				int BossPower = int.Parse(Console.ReadLine());
				int heroesPower = 0;
				foreach (var hero in heroes)
				{
					Console.WriteLine(hero.CastAbility());
					heroesPower += hero.Power;
				}
				StatusCheck(BossPower, heroesPower);
			}

			static void StatusCheck(int bossPower, int heroesPower)
			{
				if (bossPower > heroesPower)
				{
					Console.WriteLine($"Defeat...");
				}
				else
				{
					Console.WriteLine($"Victory!");
				}
			}
		}
	}
