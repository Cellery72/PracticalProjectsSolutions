using System;

namespace PracticalProjectsSolutions
{
    public static class Numbers
    {

        public static int[] GenerateFibonacciSequenceNthNumber(int nth)
        {
            int[] fibSequence = {0,1};


            for(int i=0;i<nth;++i)
            {
                var x = fibSequence[fibSequence.Length - 1] + fibSequence[fibSequence.Length - 2];
                Console.WriteLine(x);
            }
            
            return fibSequence;
        }



    }
}
