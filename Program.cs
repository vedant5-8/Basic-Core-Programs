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
                Console.WriteLine("4. Harmonic Number");
                Console.WriteLine("5. Quotient and Remainder");
                Console.WriteLine("6. Even or Odd");
                Console.WriteLine("7. Swap two numbers using temporary variable");
                Console.WriteLine("8. Swap two numbers without using temporary variable");
                Console.WriteLine("9. Find the Largest Among Three Numbers");
                Console.WriteLine("10. Check Whether an Alphabet is Vowel or Consonant.");
                Console.WriteLine("11. Computes the prime factorization.");
                Console.WriteLine("12. Exit.");
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
                        PowerOfTwo.PowerTwo();
                        break;
                    case 4:
                        HarmonicNumber.HarmonicValue();
                        break;
                    case 5:
                        QuotientAndRemainder.QuotientRemainder();
                        break;
                    case 6:
                        EvenOdd.checkEvenOdd();
                        break;
                    case 7:
                        SwapNumbers.swapWithTemp();
                        break;
                    case 8:
                        SwapNumbers.swapWithoutTemp();
                        break;
                    case 9:
                        LargestNumber.checkLargestNumber();
                        break;
                    case 10:
                        VowelsConsonants.checkVowelsOrConsonants();
                        break;
                    case 11:
                        PrimeFactors.Prime_Factors();
                        break;
                    case 12:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter correct choice.");
                        break;
                }

                Console.WriteLine();
            }

        }
    }
}
