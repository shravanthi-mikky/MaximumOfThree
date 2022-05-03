using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxOfThree
{
    public class UsingInt
    {
        public int MaximumOfThree(int a,int b,int c)
        {
            int max;
            max = a;
            if(b.CompareTo(max) > 0)
                max = b;
            if(c.CompareTo(max) > 0)
                max = c;
            return max;

        }
    }
    
}
