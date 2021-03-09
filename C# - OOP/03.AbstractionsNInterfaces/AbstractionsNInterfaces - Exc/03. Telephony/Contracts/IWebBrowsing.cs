using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Contracts
	{
	interface IWebBrowsing
		{
		public string Browse()
		{
			return string.Empty;
		}

		public string Url { get; set; }
		}
	}
