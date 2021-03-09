using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Contracts;

namespace Telephony
	{
	public class StationaryPhone : IThrowCalls
	{
		private string number;

		public StationaryPhone(string number)
		{
			this.Number = number;
		}
			public string Number
			{
				get
				{
					return this.number;
				}
				set
				{
					if (value.Any(x => char.IsLetter(x)))
					{
						throw new ArgumentException("Invalid number!");
					}
					else
					{
						this.number = value;
					}
				}
			}

			public void Call()
			{
				Console.WriteLine($"Dialing... {this.number}");
			}
		}
	}
