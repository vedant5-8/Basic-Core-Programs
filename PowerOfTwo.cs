using System;

namespace Basic_Core_Programs
{
    public class PowerOfTwo
    {
        public static void PowerTwo()
        {
            Console.WriteLine("Enter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 31)
            {
                for(int i = 0; i <= n; i++)
                {
                    Console.WriteLine("{0} ^ {1} = {2}", 2, i, Math.Pow(2, i));
                }
            } 
            else
            {
                Console.WriteLine("Enter a number is less than 31");
            }
        }
    }
}
