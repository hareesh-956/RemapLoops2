using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    internal class AgeOFCandidate
    {
        public AgeOFCandidate() 
        {
            
                // Prompt the user to enter their age
                Console.WriteLine("Enter your age:");
                int age = Convert.ToInt32(Console.ReadLine());

                // Define the minimum voting age
                int votingAge = 18;

                // Check if the candidate is eligible to vote
                if (age >= votingAge)
                {
                    Console.WriteLine("You are eligible to cast your vote.");
                }
                else
                {
                    Console.WriteLine("You are not eligible to vote yet.");
                }
            
        }
    }
}
