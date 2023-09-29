using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    internal class ArithmeticOperations
    {
        public ArithmeticOperations()
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an arithmetic operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            // Read the user's choice as an integer
            int choice = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            // Perform the arithmetic operation based on the user's choice
            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine("Result of addition: " + result);
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine("Result of subtraction: " + result);
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine("Result of multiplication: " + result);
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result of division: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
