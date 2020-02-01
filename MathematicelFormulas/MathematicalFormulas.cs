using System;

namespace MathematicelFormulas
{
    class MathematicalFormulas
    {
        static void Main(string[] args)
        {
            // Part 1
            // Partially worked example
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The circumference is {circumference}");

            // Implementation for area here
            //PI*r^2
            double area = Math.PI * (intradius * intradius);
            Console.WriteLine($"The area is {area}");


            // Part 2
            Console.WriteLine("\nPart 2, volume of a hemisphere.");

            // Implementation here
            //Volume = 4/3( Math.PI * (intradius * intradius) )
            double volume = 4 / 3 * (Math.PI * (intradius * intradius));
            Console.WriteLine($"The volume is {volume}");


            // Part 3
            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");

            // Implementation here
            //ref: social.msdn.microsoft.com/Forums/vstudio/en-US/b4176582-daf1-4b4f-b5a5-d33aed107fca/c-heron-formula?forum=csharpgeneral
            double s, area1;
            double a, b, c;

            Console.WriteLine("Enter side #1");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side #2");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side #3");
            c = double.Parse(Console.ReadLine());

            s = (a + b + c) / 2;
            area1 = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine($"The area is {area1}");


            // Part 4
            Console.WriteLine("\nPart 4, solving a quadratic equation.");

            // Implementation here

            //Console.WriteLine($"The positive solution is {positive_num / denominator}");
            //Console.WriteLine($"The negative solution is {negative_num / denominator}");
            Console.WriteLine("\nEnd of Mathematicalformulas.Program.Main()");
            Console.ReadLine();
        }
    }
}

