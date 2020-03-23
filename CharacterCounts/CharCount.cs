using System;

namespace CharacterCounts
{
    public class CharCount
    {
        public static int CountUpper(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if(char.IsUpper(input[i]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
