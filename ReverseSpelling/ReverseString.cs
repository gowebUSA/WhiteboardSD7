using System;

namespace ReverseString
{
    public class ReverseString
    {
        public static string GetReverse(string input)
        {
            string output = "";
            for (int i = 1; i <= input.Length; i++)
            {
                output += input[input.Length - i];
            }
            return output;
        }
       

        static void Main(string[] args)
        {
            Console.WriteLine("ReverseString.Program.Main()");

            string testString = "12345";
            Console.WriteLine(GetReverse(testString));
        }
    }
}
