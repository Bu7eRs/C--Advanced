using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Xml.Serialization;
using Telephony.Contracts;

namespace Telephony
	{
	public class Smartphone	: IThrowCalls, IWebBrowsing
	{
		private string url;

		private string number;
		public Smartphone()
			{
				
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

			public string Url
			{
				get
				{
					return this.url;
				}
				set
				{
					if (value.Any(c => char.IsDigit(c)))
					{
						throw new ArgumentException("Invalid URL!");
					}
					else
					{
						this.url = value;
					}
				}
			}
			public void  Call ()
			{
				Console.WriteLine($"Calling... {this.Number}");
				
			}

			public void Browse()
			{
				Console.WriteLine($"Browsing: {this.Url}!");
			}
		}
	}
