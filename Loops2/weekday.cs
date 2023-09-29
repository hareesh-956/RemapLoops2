using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Loops2
{
    internal class weekday
    {
        public weekday()
        {
            Console.WriteLine("Enter a weekday number (1-7):");

            // Read the user input as an integer
            int weekdayNumber = Convert.ToInt32(Console.ReadLine());

            string weekdayName;

            // Use a switch-case statement to determine the weekday name
            switch (weekdayNumber)
            {
                case 1:
                    weekdayName = "Monday";
                    break;
                case 2:
                    weekdayName = "Tuesday";
                    break;
                case 3:
                    weekdayName = "Wednesday";
                    break;
                case 4:
                    weekdayName = "Thursday";
                    break;
                case 5:
                    weekdayName = "Friday";
                    break;
                case 6:
                    weekdayName = "Saturday";
                    break;
                case 7:
                    weekdayName = "Sunday";
                    break;
                default:
                    weekdayName = "Invalid weekday number";
                    break;
            }

            Console.WriteLine("The corresponding weekday is: " + weekdayName);
        }
    }
}





