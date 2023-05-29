using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class PrimeFactors
    {
        public static void Prime_Factors()
        {
            Console.WriteLine("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + ", ");
                }
            }
        }
    }
}
