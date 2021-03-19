using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace P03.Detail_Printer
	{
	public interface IPrintable
		{
			public string Name { get; set; }

			public string Print();
		}
	}
