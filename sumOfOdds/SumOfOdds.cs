using System;

namespace SumOfOdds
{
    class SumOfOdds
    {
        public static int GetSumOfOdds(int nCount)
            //PascalCase is for public class.
            //camelCase is for private class.
        {
            int sum = 0;
            int nextOddNumber = 1;
                //for (int i = 0; i < i+1; i++) will be an infinite loop.
                // for (; ; ) will go forever.
                for ( int i = 0; i < nCount; i++)
            {
                sum = sum + nextOddNumber;
                //sum += nextOddNumber;

                nextOddNumber = nextOddNumber + 2;
                //nextOddNumber += 2;
            }

            return sum;

        }


        static void Main(string[] args)
        {
            Console.WriteLine("\n\tSumOfOdds.Program.Main()");

            int n = 3;
            Console.WriteLine($"\tsum of first {n} odds is: {GetSumOfOdds(n)}");
        }
    }
}
