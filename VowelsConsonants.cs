using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class VowelsConsonants
    {
        public static void checkVowelsOrConsonants()
        {
            Console.WriteLine("Enter a character: ");
            char ch = Console.ReadLine()[0];

            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("{0} is a vowel.", ch);
            }
            else if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("{0} is a vowel.", ch);
            }
            else
            {
                Console.WriteLine("{0} is a consonant.", ch);
            }
        }
    }
}
