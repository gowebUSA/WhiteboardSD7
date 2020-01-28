using System;

namespace CalculatingAverages
{
    class CalculatingAverages
    {
        public static double GetNextNumberFromUser( int number = 0 )
        {
            //prompt for input
            bool isValid = false;
            double userEntry = 0;

            while (isValid == false)  // !isValid
            {
                Console.Write($"next ({number + 1}): ");
                userEntry = double.Parse(Console.ReadLine());
                if (userEntry >= 0 && userEntry <= 100)
                {
                    isValid = true;
                }
            }
            return userEntry;
                 
        }
        public static void GetAverage(int numberOfTimes = 10)
        {
            
            int count;
            double sum = 0;

            for (count = 0; count < numberOfTimes; count++)
            {
                sum += GetNextNumberFromUser(count);

            }
            //Console.WriteLine($"\tsum of {numberOfTimes} numbers is {sum}");
            //Console.WriteLine($"\taverage: {sum / Convert.ToDouble(count)}");
            //Console.WriteLine($"\t students gets: {grade});

            Console.WriteLine($"\tsum of {numberOfTimes} numbers is {sum}");
            double score = sum / Convert.ToDouble(count);
            Console.WriteLine($"\taverage: {score}");
            Console.WriteLine($"\tgrade: {AssignLetterGrade(score)}");
        }

        public static char AssignLetterGrade(double score)
        {
            char grade = 'F';

            if (score >= 60) grade = 'D';
            if (score >= 70) grade = 'C';
            if (score >= 80) grade = 'B';
            if (score >= 90) grade = 'A';

            return grade;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n\tCalculatingAverages.Program.Main()");
            GetAverage();



        }
    }
}
