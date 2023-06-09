﻿using System;

namespace Basic_Core_Programs
{
    public class FlipCoin
    {
        public static void PercentageOfCoinFlip()
        {
            Random random = new();
            Console.WriteLine("Write how many times you want to flip the coin: ");
            int numberOfFlips = Convert.ToInt32(Console.ReadLine());

            int head = 0;
            int tail = 0;

            if (numberOfFlips > 0)
            {
                for(int i = 1; i <= numberOfFlips; i++)
                {
                    int randomNumber = random.Next(0, 2);

                    if (randomNumber == 0)
                    {
                        head++;
                    }
                    else
                    {
                        tail++;
                    }
                }

                double PercentageOfHeads = head / numberOfFlips * 100;
                double PercentageOfTails = tail / numberOfFlips * 100;

                Console.WriteLine("Percentage of Heads: {0}%", PercentageOfHeads);
                Console.WriteLine("Percentage of Tails: {0}%", PercentageOfTails);
            }
            else
            {
                Console.WriteLine("You have entered wrong value.");
                Console.WriteLine("Next time enter positive value.");
                Environment.Exit(0);
            }

        }
    }
}
