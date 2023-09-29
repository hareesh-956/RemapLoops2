using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    internal class EvenOrOdd
    {
        public EvenOrOdd() 
        {
            
                // Prompt the user to enter a number
                Console.WriteLine("Enter an integer:");
                int number = Convert.ToInt32(Console.ReadLine());

                // Check if the number is even or odd
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }
            
        }
    }
}
