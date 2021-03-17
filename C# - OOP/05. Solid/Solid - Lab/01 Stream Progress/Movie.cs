using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
	{
	public class Movie	  : IProgressable
		{
			public int Length { get; set; }

			public int Sent { get; set; }
		}
	}
