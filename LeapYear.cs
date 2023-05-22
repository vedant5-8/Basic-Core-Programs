using System;

namespace Basic_Core_Programs
{
    public class LeapYear
    {
        public static void CheckLeap()
        {
            Console.WriteLine("Enter a year: ");
            int Year = Convert.ToInt32(Console.ReadLine());
            bool leap = false;

            if(Year % 4 == 0)
            {
                if(Year % 100 == 0)
                {
                    if (Year % 400 == 0)
                    {
                        leap = true;
                    }
                    else
                    {
                        leap = false;
                    }
                } 
                else
                {
                    leap = true;
                }
            } 
            else
            {
                leap = false;
            }

            if (leap)
            {
                Console.WriteLine("{0} is a leap year.", Year);
            } 
            else
            {
                Console.WriteLine("{0} is not a leap year.", Year);
            }
        }
    }
}
