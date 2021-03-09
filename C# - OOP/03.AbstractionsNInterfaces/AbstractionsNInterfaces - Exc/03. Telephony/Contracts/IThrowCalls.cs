using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Contracts
	{
	interface IThrowCalls
		{
			
			public string Call()
			{
				return string.Empty;
			}

			public string Number { get; set; }
		}
	}
