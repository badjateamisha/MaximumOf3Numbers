using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumOfThree
{
    public class UsingString
    {
        public string MaxValueStrings(string a, string b, string c)
        {
            string max1;
            max1 = a;
            if (b.Length.CompareTo(max1.Length) > 0)
                max1 = b;
            if (c.Length.CompareTo(max1.Length) > 0)
                max1 = c;
            return max1;

        }
    }
}
