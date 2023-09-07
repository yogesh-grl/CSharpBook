using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook.LeetCode
{
    internal class BitManipulation
    {
        public string AddBinary(string a, string b)
        {
            int A = Convert.ToInt32(a, 2);
            int B = Convert.ToInt32(b, 2);

            int C = A + B;
            string retVal = Convert.ToString(C, 2).PadLeft(2, '0');
            if (a == "0" || b == "0")
            {
                retVal = Convert.ToString(C, 2);
            }
            return retVal;
        }

        public int HammingWeight(uint n)
        {
            int count = 0;
            int m = (int)n;

            while (m > 0)
            {
                count += m & 1;
                m >>= 1;
            }

            return count;
        }
    }
}
