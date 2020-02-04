using System;

namespace GetCharacterPosition
{
    public class GetCharPos
    {
        public static int GetCharacterPosition(string input, char desiredChar)
        {
            string output = " ";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[1] == desiredChar) return i + 1;
                    
             }

            return 0;


        }
        static void Main(string[] args)
        {
            Console.WriteLine("GetCharacterPosition.Program.Main()");
            Console.WriteLine("San Diego Zoo", "o");
            Console.WriteLine("San Diego Zoo", "a");
            Console.WriteLine("San Diego Zoo", "m");
        }
    }
}
