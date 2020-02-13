using System;

namespace Calendar
{
    public class Dates
    {
        public static int JulianDay(int mon, int day)
        {
            int julian = 0;

            // TODO: test for out of bounds conditions
            // past end of month or invalid month return 0
            int[] months = { 0,
                31, 28, 31, 30, 31, 30, 31,
                31, 30, 31, 30, 31, 30, 31
            };
            for (int i = 0; i < mon; i++)
            {
                julian += months[i];
            }
            return julian += day;
        }
    }
}
