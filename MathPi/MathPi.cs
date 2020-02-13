using System;

// this file contains monte carlo simulation and
// infinite loop to progressively provide an estimation
// of pi. It needs to be monitored, because it
// requires user intervation to stop it.
namespace MathPi
{
    class MathPi
    {
        public static Tuple<double,double> GetCoord(Random r)
        {
            double A = 0.0;
            double B = 0.0;

            return Tuple.Create(A, B);

        }

        //public static double getCoor(Random RandomValue)
        //{
        //    return RandomValue.NextDouble();

        //}
        public static double Radius(double x, double y) => Math.Sqrt(x * x + y * y);
        public static void EstimatePi()
        {
            //initialize random (input)
            Random r = new Random();
            int exponent = 1;  //

            while(true)        //
            //int maxValue = 4;
            //for (int exponents = 1; exponents < maxValue; exponents++)
            {
                // reset counters
                exponent++;
                int iterations;
                int inCircleCount = 0;

                // run through monte carlo methiod (processing)
                for (iterations = 0; iterations < Math.Pow(10, exponent); iterations++)
                {
                    double x = r.NextDouble();
                    // double x = 26 * r.NextDouble();
                    double y = r.NextDouble();
                    double z = Radius(x, y);

                    if (z <= 1) inCircleCount++;

                    //Other ways to write it.
                    /*
                    iterations += (z <= 1) ? 1 : 0;             ? if,    : else
                    //              if   else

                    if (z<=1)
                    {
                        iterations = iterations + 1;
                    }
                    else                     //you don't need else statement if does not do anything.
                    {
                        iterations = iterations + 0;    // or iterations++
                    }
                    */
                }
                //print the result (output)
                Console.WriteLine((double)4.0 * (double)inCircleCount / (double)iterations);
            }

            

        }
        static void Main(string[] args)
        {
            EstimatePi();
            Console.WriteLine("MathPi.Program.Main() = Monte Carlo LAB 2C");
        }
    }
}
