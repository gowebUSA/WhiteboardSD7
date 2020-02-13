using System;

namespace Quizzes
{
    class Quizzes
    {
        public static int Question7()
        {
            int y = 5;
            int x = 1;
            do
            {
                x += y;
            } while (y-- > 1);

            return x;

        }
        public static bool Question8()
        {
            bool x;
            int a = 4;
            int b = 4;

            a = ++a;
            b = b & 1;
            x = (a == b);

            return x;
        }
        public static void Question9()
        {
            MethodX();
        }
        public static int MethodX(int x=5)
        {
            int y = 2;
            if (x > y)
            {
                x %= y;
                MethodX(x);
            }
            return x;
        }
        public static int Question10()
        {
            int x = 0;
            int y = 5;
            for (int i = y; i > 0; i--)
            {
                x += (i % 2 == 1) ? i : y;
            }
            return x;
        }
        public static int Question11()
        {
            int x = 0;
            int y = 3;
            bool isTrue = true;

            while (!isTrue)
            {
                x = ++y;
                if (x >= 12)
                {
                    isTrue = (!false);
                }
            }
            return x;
        }
        static int Question12()
        {
            string string1 = "Mississippi";
            string string2 = "";
            foreach (var s in string1.Split('i'))
            {
                string2 += s;
            }
            int x = string2.Length;

            return x;

        }
        static int Question13()
        {
            int x = 0b01100011;
            return x;
        }
        static int Question14()
        {
            int x = 1;
            do
            {
                x += 10;
            } while (false);
            return x;
        }
        //static int Question15()
        //{
        //    int i;
        //    for (int i = 0; i < 10; i++)
        //    {   
        //    }
        //    int x = i;
        //    return x;
        //}
        static int Question16()
        {
            int y = 4;
            int x = 2;

            do
            {
                x += y;
            } while (y-- > 1);
            return x;
        }
        static int Question17()
        {
            int x;
            int value1 = 1;
            do
            {
                var Value1 = 'A';
                Console.WriteLine(Value1++);
            } while (value1-- > 0);
            x = value1;
            return x;
        }
        static int Question18()
        {
            int x, y = 55;

            x = y % 10;
            x *= 10;
            x += y / 10;

            return x;

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Quizzes.Program.Main()");
            Question7();
            Question8();
            Question9();
            Question10();
            Question11();
            Question12();
            Question13();
            Question14();
            //Question15();
            Question16();
            Question17();
            Question18();
        }
    }
}
