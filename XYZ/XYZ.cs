using System;

namespace XYZ
{
    class XYZ
    {
        public static int AddTwoNumbers(int first = 2, int second = 4)
        {
            return first + second;
        }
        static void Main(string[] args)
        {
            int x;
            int y = 7;
            int z;
            
            //Console.WriteLine(AddTwoNumbers()); //used both default
            Console.WriteLine(AddTwoNumbers(second:3)); //use it for the first, the second use the default
            Console.WriteLine(AddTwoNumbers(6,9)); //replaced first and second

            Console.WriteLine();
            Console.WriteLine($"\t Y = {y}");
            x = y++;
            Console.WriteLine($"\t X = {x}  , Y =  {y}");
            z = --y;
            Console.WriteLine($"\t X = {x}  , Y =  {y},  Z =  {z}  ");

            x -= (y += 5);
            Console.WriteLine($"\t X = {x}  , Y =  {y}, Z =  {z}  ");
            z += (y-=3);
            Console.WriteLine($"\t X = {x}  , Y =  {y},  Z =  {z}  ");
            z %= x;
            Console.WriteLine($"\t X = {x}  , Y =  {y},  Z =  {z}  ");

            //    x  y  z
            //14
            //16
            //18
            //21 -5 12 7
            //23 -5 9  16
            //25 -5 9  1

            for (int i = 1; i < -5; --i)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 1) continue;
                //Console.Write( " {0}", i);
                Console.Write($" {i}");
            }

            //for (int j = 0; ; j+=100000)  //bad code
            //{
            //    Console.WriteLine(j);
            //}

                for (int numApples = 0; numApples < 3; numApples++)
            {
                Console.WriteLine($"{numApples} + apple({numApples}>1)?'s':' ' ");
                //                 if                  then               else
            }



        }
    }
}
