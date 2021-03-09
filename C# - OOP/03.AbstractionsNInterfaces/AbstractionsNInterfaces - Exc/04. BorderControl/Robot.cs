using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BorderControl
	{
	public class Robot
		{

			public Robot(string name, string id)
			{
				Name = name;
				Id = id;
			}
			public string Name { get; set; }

			public string Id { get; set; }
		}
	}
