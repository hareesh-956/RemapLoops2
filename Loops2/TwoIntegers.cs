using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    internal class TwoIntegers
    {
        public  TwoIntegers()
        {
            // Prompt the user to enter two integers
            Console.WriteLine("Enter the first integer:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second integer:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Check if the two integers are equal
            if (num1 == num2)
            {
                Console.WriteLine("The two integers are equal.");
            }
            else
            {
                Console.WriteLine("The two integers are not equal.");
            }
        }
    }
}
