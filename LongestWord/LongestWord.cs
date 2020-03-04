using System;

namespace LongestWord
{
    class LongestWord
    {
        static void LongWord(string sentence)
        {
            string line = "I love my work.";
            string[] words = sentence.Split(" ");
            int counter = 0;

            for (int i = 0; i < words.Length; i++)
            {

            }
        }
        static void Main(string[] args)
        {
            string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine(word);
            Console.WriteLine("Longest Word");

        }
    }
}
