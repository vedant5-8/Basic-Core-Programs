using System;

namespace Basic_Core_Programs
{
    public class QuotientAndRemainder
    {
        public static void QuotientRemainder()
        {
            Console.WriteLine("Enter a dividend: ");
            int Dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a divisor: ");
            int Divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = Dividend / Divisor;
            int remainder = Dividend % Divisor;

            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);
        }
    }
}
