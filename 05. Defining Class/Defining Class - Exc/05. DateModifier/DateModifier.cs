using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
   public class DateModifier
    {

        public static int GetDifferenceBetweenDates(string dateOneStr, string dateTwoStr)
        {
            DateTime dateOne = DateTime.Parse(dateOneStr);
            DateTime dateTwo = DateTime.Parse(dateTwoStr);

            TimeSpan diff = dateOne - dateTwo;
            return diff.Days;
        }

    }
}
