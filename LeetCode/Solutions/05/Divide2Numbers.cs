using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._05
{
    internal class Divide2Numbers
    {
        public int Divide(int dividend, int divisor)
        {
            long positiveDividend = dividend;
            long positiveDivisor = divisor;
            positiveDividend = Math.Abs(positiveDividend);
            positiveDivisor = Math.Abs(positiveDivisor);

            if ((dividend >= 0 && divisor > 0) || (dividend <= 0 && divisor < 0))
            {
                var quotient = DivideWithSameSign(positiveDividend, positiveDivisor);
                return quotient == int.MinValue ? int.MaxValue : -quotient;
            }
            else
            {
                return DivideWithSameSign(positiveDividend, positiveDivisor);
            }
        }

        private int DivideWithSameSign(long dividend, long divisor)
        {
            int result = 0;

            while (dividend >= divisor)
            {
                result--;
                dividend -= divisor;
            }

            return result;
        }
    }
}
