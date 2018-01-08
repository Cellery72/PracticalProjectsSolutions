using System.Collections.Generic;

namespace PracticalProjectsSolutions
{
    public static class ClassicAlgorithms
    {
        // Collatz Conjecture
        // Start with a number n > 1. Find the number of steps it takes to reach one using the following process: If n is even, divide it by 2. If n is odd, multiply it by 3 and add 1.
        public static int CollatzConjecture(uint n)
        {
            int count = 0;
            
            // if num is 1, return 0 because no steps were necessary
            if(n==1)
            {
                return count;
            }            
            
            do
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                    count++;
                }
                else
                {
                    n = (n * 3) + 1;
                    count++;
                }
            } while (n!=1);
            return count;
        }

        public static List<int> MergeSort(List<int> list, int lowest, int highest)
        {
            List<int> returnValue = new List<int>();



            return returnValue;
        }

        public static List<int> BubbleSort(List<int> list, int lowest, int highest)
        {
            List<int> returnValue = new List<int>();


            return returnValue;
        }

    }
}
