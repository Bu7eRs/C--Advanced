using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace SoftuniParty
	{
	class Program
		{
		static void Main (string[] args)
			{
			List<string> Party = new List<string>();
			string input = Console.ReadLine();
			while (true)
			{

				if (input.ToLower() == "end")
				{
					Console.WriteLine(Party.Count);
					Party.Sort();
					foreach (var guest in Party)
					{
						Console.WriteLine(guest);
					}
					break;
				}

				if (input.ToLower() == "party")
				{
					while (input.ToLower() != "end")
					{
						
						Party.Remove(input);
						input = Console.ReadLine();
					}

					continue;
				}
				else
				{
					Party.Add(input);
				}
				input = Console.ReadLine();
			}
			
			}
		}
	}
