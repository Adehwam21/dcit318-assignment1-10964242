using System;

namespace TicketPriceCalculator
{
    public class Program
    {
        private const double ticketPrice = 10.00;
        private const double ticketDiscountRate = 0.3;

        public static string CanGetDiscount(int age)
        {   
            if (age <= 0)
            {
                return "\nAge cannot be a negative integer. Enter a positive integer next time.";
            }
            else if (age <= 12 || age >= 65)
            {

                double newTicketPrice = ticketPrice - (ticketDiscountRate * ticketPrice);

                return $"\nCongratulations! You are eligible for a discount." +
                    $"\nYour ticket price is GHc {newTicketPrice}" +
                    $"\nEnjoy the movie!";
                
            }
            else
            {
                return $"\nOops! You do not qualify for a discount." +
                    $"\nYour ticket price is GHc {ticketPrice}" +
                    $"\nEnjoy the movie!";
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Movie Fanatic!\nWelcome to my Ticket Calculator App." +
                              "\nFeeling Lucky? Enter your age to check if you qualify for a discount on your ticket: ");
            
            
            // Prompt user to continuously enter a valide age.
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Please enter a valid age. Should be a positive integer. ");
            }

            string alert = CanGetDiscount(age);
            Console.WriteLine(alert);
        }
    }
}
