using System;

namespace FlattenArray
{
    class FlattenArray
    {

        static void FlatArray()
        {
            //Get all numbers in a single row.
            int[,] X =
            {
                { 5, 8, 1, 35, 11},
                { 4, 8, 2, 28, 11},
                { 3, 3, 3, 99, 11}
            };
            int[] Y = new int[X.Length]; // X.Length contains the total # of elements

            int k = 0;
            for (int i = 0; i < X.GetLength(0); i++)  // step through the first dimension
            {
                for (int j = 0; j < X.GetLength(1); j++) // step through second dimension
                {
                    Y[k++] = X[i, j];
                }
            }

            for (int i = 0; i < Y.Length;)
            {
                Console.Write($"{Y[i]}{(++i < Y.Length ? "," : "\n")}");
            }
        }

        
        static int DistinctArray(int[] numbers)
        {
            //numbers = { { 5, 3, 5, 11, 5 } };
            //int[] distNr = new int[numbers.Length];
            int count = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                bool isNew = true;
                for (int j = 0; i < i; i++)
                {
                    if (numbers[i] == numbers[j])
                        isNew = false;
                }
                if (isNew) count++;
            }
            return count;
            Console.Write(numbers);
        }    
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Flatten Array");
            FlatArray();
            //DistinctArray();
        }

        //private static void DistinctArray()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
