using System;

namespace GradeCalculator
{
    class Program
    {
        // Grading method
        public static string Grading(int score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(
                "Hello Student!\nWelcome to my GradeCalculator App.\n" +
                "Enter a whole number in the scale of 0 - 100 to find the grade: "
                );

            bool isValidScore = int.TryParse(Console.ReadLine(), out int score);

            if (!isValidScore)
            {
                Console.WriteLine("\nInvalid input! Please enter a valid integer next time.\n");
            }
            else if (score < 0 || score > 100)
            {
                Console.WriteLine("\nMake sure the number falls in the scale 0 - 100.");
            }
            else
            {
                string grade = Grading(score);
                Console.WriteLine($"\n{score} is equivalent to {grade}.");

            }
        }
    }
}
