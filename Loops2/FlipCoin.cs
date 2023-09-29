using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    internal class FlipCoin
    {
        public FlipCoin() 
        {
            int headsCount = 0;
            int tailsCount = 0;
            Random random = new Random();

            while (headsCount < 20 && tailsCount < 20)
            {
                // Generate a random number (0 or 1) to represent a coin flip
                int result = random.Next(2);

                if (result == 0)
                {
                    Console.WriteLine("Heads");
                    headsCount++;
                }
                else
                {
                    Console.WriteLine("Tails");
                    tailsCount++;
                }
            }

            if (headsCount >= 20)
            {
                Console.WriteLine("Heads wins 20 times!");
            }
            else
            {
                Console.WriteLine("Tails wins 20 times!");
            }
        }
    }
}
