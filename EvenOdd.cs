using System;

namespace Basic_Core_Programs
{
    public class EvenOdd
    {
        public static void checkEvenOdd()
        {
            Console.Write("Enter a number to check: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0) 
            {
                Console.WriteLine("{0} is an even number.", num);
            }
            else
            {
                Console.WriteLine("{0} is an odd number.", num);
            }
        }
    }
}
