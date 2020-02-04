using System;

namespace PalindromeLib
{
    public class Palindrome
    {
        public static bool IsPalindrome(string input)
        {
            input.ToLower();
            int palinIndex = input.Length - 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != input[palinIndex--])
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome.Program.Main()");

            string str;
            str = "racecar";
            Console.WriteLine($"{str}? {IsPalindrome(str)}");
            str = "mom mom";
            Console.WriteLine($"{str}? {IsPalindrome(str)}");
            str = "Racecar";
            Console.WriteLine($"{str}? {IsPalindrome(str)}");
        }
    }
}
