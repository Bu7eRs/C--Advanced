using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {

            return this.Count == 0;

        }

        public void AddRange(IEnumerable<string> strings)
        {
            foreach (var s in strings)
            {
                this.Push(s);
            }
        }
    }
}
