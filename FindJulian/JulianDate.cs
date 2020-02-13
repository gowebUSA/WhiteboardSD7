using System;

namespace FindJulian
{
    class JulianDate
    {
        public static int FindJulian()
        {
            Console.Write("Enter month: ");
            int month = (int) Console.Read();
            if (month > 1 && month < 13)
            {
                Console.Write("Enter day: ");
                
            }
            int day = (int)Console.Read();

            if (month == 1)
            {
                month = 31;
            }
            else if (month == 2)
            {
                month = 59;
            }
            else if (month == 3)
            {
                month = 90;
            }
            else if (month == 4)
            {
                month = 120;
            }
            else if (month == 5)
            {
                month = 151;
            }
            else if (month == 6)
            {
                month = 181;
            }
            else if (month == 7)
            {
                month = 212;
            }
            else if (month == 8)
            {
                month = 243;
            }
            else if (month == 9)
            {
                month = 273;
            }
            else if (month == 10)
            {
                month = 304;
            }
            else if (month == 11)
            {
                month = 334;
            }
            else if (month == 11)
            {
                month = 365;
            }

            

            int julian = month - (month - day);
            return julian;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("FindJulian.Program.Main()");
            Console.WriteLine($"The Julian Date is {FindJulian()}");


        }
    }
}
