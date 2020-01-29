using System;

namespace EX3AErrorsExceptions
{
    class Program
    {
        public static void AreaCircle()
        {
            //Circle Area = pi x r^2
            try
            {

                int r;
                double A;
                Console.Write("Enter the radius: ");
                r = Convert.ToInt32(Console.ReadLine());
                A = (3.14) * r * r;
                Console.WriteLine($"The Area of circle of given radius is= {A}");
                Console.ReadLine();
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx);
                Console.ReadLine();
            }
        }

        public static void AreaTriangle()
        {
            //Triangle Area = 1/2(base x height)
            try
            {
                Console.Write("Please write the \"b\" value of your triangle: ");
                decimal bSide = decimal.Parse(Console.ReadLine());
                Console.Write("Please write the \"h\" value of your triangle: ");
                decimal hSide = decimal.Parse(Console.ReadLine());

                decimal area = (bSide * hSide) / 2;
                Console.WriteLine("The area of your triangle is: {0}", area);
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx);
                Console.ReadLine();
            }
        }
        public static void AreaHemisphere() 
        {
            // Hemisphere Area  = 4 * pi * r^2
            try
            {

                int r;
                double area, volume, pi = 3.14;
                Console.Write("Enter the radius of sphere: ");
                r = Convert.ToInt32(Console.ReadLine());
                area = 3 * pi * r * r;
                volume = 1.333 * pi * r * r * r;
                Console.WriteLine("Surface Area of sphere:" + area);
                Console.WriteLine("Volume of sphere:" + volume);
                Console.ReadKey();
            }
            catch(FormatException fEx)
            {
                Console.WriteLine(fEx);
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        //ref: forgetcode.com/csharp/1514-area-of-circle
        //ref: forum.tutorials7.com/1156/how-to-calculate-an-area-of-a-triangle-in-c%23-and-visual-basics
        //ref: csharp-console-examples.com/basic/c-program-to-calculate-the-volume-and-surface-area-of-sphere
        {
            Console.WriteLine("EX3AErrorsExceptions.Priogram.Main()");
            AreaCircle();
            AreaTriangle();
            AreaHemisphere();
            

        }
    }
}
