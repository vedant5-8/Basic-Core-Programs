using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    public class HarmonicNumber
    {
        public static void HarmonicValue()
        {
            Console.WriteLine("Enter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;

            if (n != 0)
            {
                for(int i = 1; i <= n; i++)
                {
                    sum += 1 / (double)i;
                }
                Console.WriteLine("Sum of harmonic series upto {0} terms : {1}", n, sum);
            }
            else
            {
                Console.WriteLine("Nth number is not 0 and negative.");
            }
        }
    }
}
