using System;

namespace ClockDegreeAngle
{
    class ClockAngle
    {
        public static int GetAngle(int h, int m)
        {
            //gowebUSA
            int currentAngle;
            
            //Console.WriteLine("Enter hour: ");
            //h = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter minute (15, 30, 45, 60 only): ");
            //m = int.Parse(Console.ReadLine());

            int zero = 0;
            int ninety = 90;
            int one80 = 180;
            int three60 = 360;

            if (m <= 15)
            {
                m = zero;
            }
            if (m > 15)
            {
                m = ninety;
            }
            if (m > 30)
            {
                m = one80;
            }
            if (m > 45)
            {
                m = three60;
            }
            if (h <= 3)
            {
                h = zero;
            }
            if (h > 3)
            {
                h = ninety;
            }
            if (h > 6)
            {
                h = one80;
            }
            if (h > 9)
            {
                h = three60;
            }
            if (h == m)
            {
                currentAngle = zero;
            }

            return m;
        }
        class SmartClock
        {
            //www.c-sharpcorner.com/article/find-out-the-angle-between-hour-hand-and-minute-hand-in-c-sharp/
            public double GetAngleBetweenHourAndMinuteHand(int hour, int minute)
            {
                //∆θ=|5(6H-11/10M) |0  
                //hour =>H   
                //minute=>M  
                return Math.Abs(5 * ((6 * hour) - (1.1 * minute)));
            }
        }
        static int calcAngle(double h, double m)
        {
            //www.geeksforgeeks.org/calculate-angle-hour-hand-minute-hand/
            // validate the input 
            if (h < 0 || m < 0 ||
                h > 12 || m > 60)
                Console.Write("Wrong input");

            if (h == 12)
                h = 0;

            if (m == 60)
                m = 0;

            // Calculate the angles moved by hour and 
            // minute hands with reference to 12:00 
            int hour_angle = (int)(0.5 * (h * 60 + m));   //#1: 300
            int minute_angle = (int)(6 * m);            //360

            // Find the difference between two angles 
            int angle = Math.Abs(hour_angle - minute_angle);
                                //   300 -     360  = -60   Abs=60

            // smaller angle of two possible angles 
            angle = Math.Min(360 - angle, angle);
                            // 360 - 60 = 300, 60)    Min = -60

            return angle;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ClockDegreeAngle");
            Console.WriteLine(GetAngle(3, 30));
            //Console.WriteLine(GetAngleBetweenHourAndMinuteHand(3, 30));
            Console.WriteLine($"#1: {calcAngle(9, 60)}");    // Ans: 90
            Console.Write(calcAngle(3, 30));                // Ans: 75


        }
    }
}
