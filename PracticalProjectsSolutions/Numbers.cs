using System;
using System.Collections.Generic;

namespace PracticalProjectsSolutions
{
    public static class Numbers
    { 
        // Fibonacci Sequence
        // Enter a number and have the program generate the Fibonacci sequence to that number or to the Nth number.
        public static List<int> GenerateFibonacciSequenceNthNumber(int nth)
        {
            List<int> fibSequence = new List<int>(new int[] {0,1});

            if(nth==0)
            {
                return new List<int> { 0 };
            }
            else if(nth==1)
            {
                return fibSequence;
            }
            else
            {
                // loop as many times as user specified
                for (int i = 1; i < nth - 1; ++i)
                {
                    var x = fibSequence[fibSequence.Count - 1] + fibSequence[fibSequence.Count - 2];
                    fibSequence.Add(x);
                }
            }
            
            return fibSequence;
        }

        // Prime Factorization
        //Have the user enter a number and find all Prime Factors (if there are any) and display them.
        public static List<int> PrimeFactorization(int nth)
        {
            List<int> retValue = new List<int>();

            for(int i=1;i<=nth;++i)
            {
                if(Utility.IsPrimeNumber(i))
                {
                    retValue.Add(i);
                }
            }
            return retValue;
        }

        // Find Cost of Tile to Cover W x H Floor
        // Calculate the total cost of tile it would take to cover a floor plan of width and height, using a cost entered by the user.
        public static decimal FindCostOfTile(decimal cost, double width, double length)
        {
            int area = (int)Math.Floor(width * length)+1;
            return area * cost;
        }
    }
}
