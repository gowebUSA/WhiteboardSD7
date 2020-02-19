using System;

namespace SortArray
{
    class SortArray
    {
        //public int[] SortingArray(int[] input)
        //{
        //    int stack = 0;
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        if (input[i] < input[++i])
        //        {
        //            stack++;
        //        }
        //    }
        //    return stack;

        //}
        static void doStuff()
        {
            int[] scores = new int[5]; // nt[] scores; is declaring, = new int[5]; is initializing
            int[] testSscores = { 88, 5, 75, 42, 8 };

            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }
            foreach (var score in testSscores)
            {
                Console.WriteLine(score);
            }
            Console.WriteLine(testSscores);
            Console.WriteLine($"First: {testSscores[0]}");
            Console.WriteLine($"Last: {testSscores[testSscores.Length-1]}");
            Console.WriteLine(string.Join(",",testSscores));  //you can use other separator "," like " | "
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Sort Array ");
            doStuff();

        }
    }
}
