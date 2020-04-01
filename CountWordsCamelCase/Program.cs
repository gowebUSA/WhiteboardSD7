using System;

namespace CountWordsCamelCase
{
    class Program
    {
        static int CountWords1(String str1)
        {
            int count = 0;

            for (int i = 0; i < str1.Length - 1; i++)
            {
                if (str1[i] >= 'A' && str1[i] <= 'Z')
                    count++;
            }

            return count + 1;
        }
        static int CountWords(String str)
        {
            int count = 1;

            for (int i = 1; i < str.Length; i++)
            {
                if (char.IsUpper(str[i])) count++;
            }

            return count;
        }
        static void Main(string[] args)
        {
            String str = "geeksForGeeks";
            String str1 = "camelCase";

            Console.Write(CountWords(str));
            Console.Write("\n" + CountWords1(str1));
        }
    }
}
