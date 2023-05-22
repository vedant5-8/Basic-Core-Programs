using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    public class SwapNumbers
    {
        public static void swapWithTemp()
        {
            Console.WriteLine("Swap two numbers using temporary variable");
            Console.WriteLine("Enter first number: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int second = Convert.ToInt32(Console.ReadLine());

            int temp = first;

            first = second; 
            
            second = temp;

            Console.WriteLine("---After Swap---");
            Console.WriteLine("First Number: " + first);
            Console.WriteLine("Second Number: " + second);
        }

        public static void swapWithoutTemp()
        {
            Console.WriteLine("Swap two numbers without using temporary variable");
            Console.WriteLine("Enter first number: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int second = Convert.ToInt32(Console.ReadLine());

            first = first - second;
            second = first + second;
            first = second - first;

            Console.WriteLine("---After Swap---");
            Console.WriteLine("First Number: " + first);
            Console.WriteLine("Second Number: " + second);
        }
    }
}
