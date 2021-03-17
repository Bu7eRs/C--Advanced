using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
	{
	public interface IProgressable	
		{
			 int Length { get; set; }
			 int Sent { get; set; }

		}
	}
