using System;

namespace EX3AErrorsExceptions
{
    class Program
    {
        public static void AreaCircle()
        {
            checked
            {
                //Circle Area = pi x r^2
                try
                {

                    int r;
                    double A;
                    Console.Write("\n\n");
                    Console.Write("Calculate Area of a Circle :\n");
                    Console.Write("----------------------------------------");
                    Console.Write("\n\n");
                    Console.Write("Enter the radius: ");
                    r = Convert.ToInt32(Console.ReadLine());
                    A = (3.14) * r * r;
                    Console.WriteLine($"The Area of circle of given radius is= {A}");

                }
                catch (FormatException fEx)
                {
                    Console.WriteLine(fEx.Message + " Please hit enter to continue.");
                    Console.ReadLine();
                    AreaCircle();
                }
            }
        }

        public static void AreaTriangle()
        {
            //Triangle Area = 1/2(base x height)
            try
            {
                Console.Write("\n\n");
                Console.Write("Calculate Area of a Triangle :\n");
                Console.Write("----------------------------------------");
                Console.Write("\n\n");
                Console.Write("\nPlease write the \"b\" value of your triangle: ");
                decimal bSide = decimal.Parse(Console.ReadLine());
                Console.Write("Please write the \"h\" value of your triangle: ");
                decimal hSide = decimal.Parse(Console.ReadLine());

                decimal area = (bSide * hSide) / 2;
                Console.WriteLine("The area of your triangle is: {0}", area);
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message + " Please hit enter to continue.");
                Console.ReadLine();
                AreaTriangle();
            }
        }
        public static void AreaHemisphere() 
        {
            // Hemisphere Area  = 4 * pi * r^2
            try
            {

                int r;
                double area, volume, pi = 3.14;
                Console.Write("\n\n");
                Console.Write("Calculate Area of a Hemisphere :\n");
                Console.Write("----------------------------------------");
                Console.Write("\n\n");
                Console.Write("\nEnter the radius of sphere: ");
                r = Convert.ToInt32(Console.ReadLine());
                area = 3 * pi * r * r;
                volume = 1.333 * pi * r * r * r;
                Console.WriteLine("Surface Area of sphere:" + area);
                Console.WriteLine("Volume of sphere:" + volume);
                
            }
            catch(FormatException fEx)
            {
                Console.WriteLine(fEx.Message + " Please hit enter to continue.");
                Console.ReadLine();
                AreaHemisphere();
            }
        }
        public static void QuadraticExpression()
        {
            //ax2 + bx + c = 0
            try
            {

                int a, b, c;

                double d, x1, x2;
                Console.Write("\n\n");
                Console.Write("Calculate root of Quadratic Equation :\n");
                Console.Write("----------------------------------------");
                Console.Write("\n\n");

                Console.Write("Input the value of a : ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the value of b : ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the value of c : ");
                c = Convert.ToInt32(Console.ReadLine());

                d = b * b - 4 * a * c;
                if (d == 0)
                {
                    Console.Write("Both roots are equal.\n");
                    x1 = -b / (2.0 * a);
                    x2 = x1;
                    Console.Write("First  Root Root1= {0}\n", x1);
                    Console.Write("Second Root Root2= {0}\n", x2);
                }
                else if (d > 0)
                {
                    Console.Write("Both roots are real and diff-2\n");

                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);

                    Console.Write("First  Root Root1= {0}\n", x1);
                    Console.Write("Second Root root2= {0}\n", x2);
                }
                else
                    Console.Write("Root are imeainary;\nNo Solution. \n\n");
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message + " Please hit enter to continue.");
                Console.ReadLine();
                QuadraticExpression();
            }

        }
        static void Main(string[] args)
        //ref: AreaCircle. forgetcode.com/csharp/1514-area-of-circle
        //ref: AreaTriangle. forum.tutorials7.com/1156/how-to-calculate-an-area-of-a-triangle-in-c%23-and-visual-basics
        //ref: AreaHemisphere. csharp-console-examples.com/basic/c-program-to-calculate-the-volume-and-surface-area-of-sphere
        //ref: QuadraticExpression. w3resource.com/csharp-exercises/conditional-statement/csharp-conditional-statement-exercise-11.php
        {
            Console.WriteLine("EX3AErrorsExceptions.Priogram.Main()");
            AreaCircle();
            //AreaTriangle();
            //AreaHemisphere();
            //QuadraticExpression();



        }
    }
}
