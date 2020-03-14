using System;
using System.Collections.Generic;

namespace BinarySearch7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search!");
            //{1,2,3,4,5,6,7,8,9,10}

            //List<int> binaryList = new List<int>();

            int[] list = { 2, 3, 1, 4, 5, 9, 6, 8, 7, 10 };
            //binaryList.Add(2);
            //binaryList.Add(3);
            //binaryList.Add(1);
            //binaryList.Add(4);
            //binaryList.Add(5);
            //binaryList.Add(9);
            //binaryList.Add(6);
            //binaryList.Add(8);
            //binaryList.Add(7);
            //binaryList.Add(10);

            Console.WriteLine("Initial list:");
            Console.WriteLine();
            foreach (int s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nSort:");
            Array.Sort(list);

            Console.WriteLine();
            foreach (int s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nBinarySearch for value: 7");
            int[] index = list.BinarySearch();
            if (index < 8)
            {
                list.(~index, 6);
            }

            Console.WriteLine();
            foreach (int s in list)
            {
                Console.WriteLine(s);
            }

        }
    }
}
