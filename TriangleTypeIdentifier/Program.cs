using System;

namespace TriangleTypeIdentifier
{
    public class Program
    {
        public static string KnowTriangleType(int side1, int side2, int side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                return "Invalid triangle sides. All sides must be positive integers.";
            }

            // Making sure the triangle equality theorem holds.
            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                return "Invalid triangle. The sum of any two sides must be greater than the third side.";
            }

            if (side1 == side2 && side2 == side3)
            {
                return "The triangle is an Equilateral Triangle.";
            }
            else if (side1 != side2 && side1 != side3 && side2 != side3)
            {
                return "The triangle is a Scalene Triangle.";
            }
            else
            {
                return "The triangle is an Isosceles Triangle.";
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(
                "Hey there Math Geek!\nWelcome to my Triangle Type Identifier App." +
                "\nEnter the length of the sides of your triangle to check the type: "
            );

            Console.WriteLine("\nEnter first side: ");
            bool isValidS1 = int.TryParse(Console.ReadLine(), out int s1);

            Console.WriteLine("\nEnter second side: ");
            bool isValidS2 = int.TryParse(Console.ReadLine(), out int s2);

            Console.WriteLine("\nEnter third side: ");
            bool isValidS3 = int.TryParse(Console.ReadLine(), out int s3);

            if (!isValidS1 || !isValidS2 || !isValidS3)
            {
                Console.WriteLine("Invalid input. Please enter valid integers for all sides.");
            }
            else
            {
                string result = KnowTriangleType(s1, s2, s3);
                Console.WriteLine(result);
            }
        }
    }
}
