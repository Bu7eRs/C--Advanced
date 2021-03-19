using System;
using System.Collections.Generic;
using System.Text;
using P03.Detail_Printer;

namespace P03.DetailPrinter
{
    public class Manager : IPrintable
    {
        public Manager(string name, ICollection<string> documents)
        {
            this.Documents = new List<string>(documents);
            this.Name = name;
        }

        public string Name { get; set; }

        public IReadOnlyCollection<string> Documents { get; set; }

        public string Print()
        {
	        StringBuilder sb = new StringBuilder();
	        sb.AppendLine(this.Name);
	        sb.AppendLine(string.Join(" ", this.Documents));
	        return sb.ToString();

	    }

    }
}
