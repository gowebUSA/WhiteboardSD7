using System;

namespace SwapValue
{
    public class Swap
    {
        public static void SwapValue(ref int x, ref int y)
        {
            y = x + y;
            x = y - x;  //(x+y) -x => y
            y -= x;
        }
    }
}
