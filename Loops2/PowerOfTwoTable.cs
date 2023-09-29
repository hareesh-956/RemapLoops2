using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    internal class PowerOfTwoTable
    {
        public PowerOfTwoTable() 
        {
            Console.WriteLine("Enter a value for 'n':");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Please enter a non-negative value for 'n'.");
                return;
            }

            Console.WriteLine("Powers of 2 less than or equal to 2^n:");

            int powerOfTwo = 1;
            int exponent = 0;

            while (powerOfTwo <= Math.Pow(2, n))
            {
                Console.WriteLine($"2^{exponent} = {powerOfTwo}");
                powerOfTwo *= 2;
                exponent++;
            }
        }
    }
}
