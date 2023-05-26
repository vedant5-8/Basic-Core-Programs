using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class LargestNumber
    {
        public static void checkLargestNumber()
        {
            Console.WriteLine("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            if(firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("{0} is larger than {1} and {2}", firstNumber, secondNumber, thirdNumber);
            } 
            else if (secondNumber > thirdNumber && secondNumber > firstNumber)
            {
                Console.WriteLine("{0} is larger than {1} and {2}", secondNumber, firstNumber, thirdNumber);
            } else
            {
                Console.WriteLine("{0} is larger than {1} and {2}", thirdNumber, firstNumber, secondNumber);
            }
        }
    }
}
