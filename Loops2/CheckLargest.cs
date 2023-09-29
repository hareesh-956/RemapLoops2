using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    internal class CheckLargest
    {
        public CheckLargest()
        {
            Console.WriteLine("Enter three numbers:");

            // Read three numbers from the user
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());

            double largest;

            // Check which number is the largest using if-else if-else statements
            if (num1 >= num2 && num1 >= num3)
            {
                largest = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                largest = num2;
            }
            else
            {
                largest = num3;
            }
            Console.WriteLine("The largest number is: " + largest);
        }
    }
}



