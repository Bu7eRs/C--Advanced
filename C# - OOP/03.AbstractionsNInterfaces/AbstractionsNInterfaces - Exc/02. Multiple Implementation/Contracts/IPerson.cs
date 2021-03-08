using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo.Contracts
	{
	interface IPerson
		{
			public string Name { get; set; }

			public int Age { get; set; }
		}
	}
