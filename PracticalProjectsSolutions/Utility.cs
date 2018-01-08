using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalProjectsSolutions
{
    public static class Utility
    {
        public static bool IsPrimeNumber(int num)
        {
            for(int i=2;i<num;++i)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static string ListToString(List<int> list)
        {
            return string.Join(",", list.ToArray());
        }

        public static int CalculateFactorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * CalculateFactorial(i - 1);
        }
    }
}
