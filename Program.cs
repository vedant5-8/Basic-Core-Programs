using Basic_Core_Programs;
using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args) {
            
            while (true)
            {
                Console.WriteLine("Choose a number: ");
                Console.WriteLine("1. Flip Coin and print percentage of Heads and Tails");
                Console.WriteLine("2. Leap Year");
                Console.WriteLine("3. Power of 2");
                Console.WriteLine("4. Exit.");
                Console.Write("=>");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        FlipCoin.PercentageOfCoinFlip();
                        break;
                    case 2:
                        LeapYear.CheckLeap();
                        break;
                    case 3: 
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter correct choice.");
                        break;
                }
            }

        }
    }
}
