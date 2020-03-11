using System;

namespace CountCapsLetter
{
    public class CountCaps
    {

        public static int CountCapsLetter(string s)         //without using void, it will requiree a return statement.
        {                                                   //then you have to use the Method() in Main. 
            Console.WriteLine("Enter a phrase: ");
            s = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i])) count++;
            }

            return count;
        }

        static void Main(string[] args)
        {
            //int s = Program.CountCapsLetter();
            //int count = 0;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (char.IsUpper(s[i])) count++;
            //}
            Console.WriteLine("CountCapsLetter is: " + CountCapsLetter(""));  //You cannot use {count} bec it's outside the scope of Main().
            //Console.WriteLine("This is jiust calling CountCapsLetter() Method():" + s);

            //IDempoteent. ToLower, if it changed, then is caps, if it didn't changed, then it's already a lower.
            //Using string literal >='A' && <='Z'.
        }
    }
}
