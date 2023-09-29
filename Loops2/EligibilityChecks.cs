using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    internal class EligibilityChecks
    {
        public EligibilityChecks()
        {
            Console.WriteLine("Input the marks obtained in Physics:");
            int physicsMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the marks obtained in Chemistry:");
            int chemistryMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the marks obtained in Mathematics:");
            int mathMarks = Convert.ToInt32(Console.ReadLine());

            // Check eligibility based on the criteria
            if (mathMarks >= 65 && physicsMarks >= 55 && chemistryMarks >= 50 && (mathMarks + physicsMarks + chemistryMarks >= 180))
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else if (mathMarks >= 65 && (physicsMarks >= 55 || chemistryMarks >= 55) && (mathMarks + physicsMarks >= 140))
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }
    }
}
