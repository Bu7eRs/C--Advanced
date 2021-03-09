using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
	{
	class Program
		{
		static void Main (string[] args)
		{
			string input = Console.ReadLine();
			List<Citizen> citizens = new List<Citizen>();
			List<Robot> robots = new List<Robot>();
				while (true)
				{
					if (input.ToLower() == "end")
					{
						string faultyIds = Console.ReadLine();
						foreach (var citizen in citizens)
						{
							if (citizen.Id.EndsWith(faultyIds))
							{
								Console.WriteLine(citizen.Id);
							}
						}
						foreach (var robot in robots)		
						{
							if (robot.Id.EndsWith(faultyIds))
							{
								Console.WriteLine(robot.Id);
							}
						}
						break;
					}
					string[] data = input
						.Split(" ", StringSplitOptions.RemoveEmptyEntries)
						.ToArray();
					if (data.Length == 2)
					{
						Robot currRobot = new Robot(data[0], data[1]);
						robots.Add(currRobot);
					}
					else if (data.Length == 3)
					{
						Citizen currCitizen = new Citizen(data[0], int.Parse(data[1]), data[2]);
						citizens.Add(currCitizen);
					}

					input = Console.ReadLine();
				}
			}
		}
	}
