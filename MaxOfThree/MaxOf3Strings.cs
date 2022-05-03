using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxOfThree
{
    public class MaxOf3Strings
    {
        public string MaximumOfThre(string a, string b, string c)
        {
            string max;
            max = a;
            if (b.Length.CompareTo(max.Length) > 0)
                max = b;
            if (c.Length.CompareTo(max.Length) > 0)
                max = c;
            return max;

        }
    }
}
