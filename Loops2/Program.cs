namespace Loops2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please choose any option from below option");
            Console.WriteLine("1.TwoIntegers \n2.EvenOrOdd \n3.AgeOfCandidates \n4.CheckLargest \n5.EligibilityChecks \n6.weekday \n7.ArithmeticOperations \n8.PowerOfTwoTable \n9.FlipCoin \n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    TwoIntegers s = new TwoIntegers();
                    Console.WriteLine();
                    break;

               case 2:
                    EvenOrOdd b = new EvenOrOdd();
                    Console.WriteLine();
                    break;

               case 3:
                    AgeOFCandidate c    = new AgeOFCandidate();
                    Console.WriteLine();
                    break;

               case 4:
                    CheckLargest d = new CheckLargest();
                    Console.WriteLine();
                    break;

               case 5:
                    EligibilityChecks e = new EligibilityChecks();
                    Console.WriteLine();
                    break;

               case 6:
                    weekday f = new weekday();
                    Console.WriteLine();
                    break;

               case 7:
                    ArithmeticOperations g = new ArithmeticOperations();
                    Console.WriteLine();
                    break;

               case 8:
                    PowerOfTwoTable h = new PowerOfTwoTable();
                    Console.WriteLine();
                    break;

               case 9:
                    FlipCoin i = new FlipCoin();
                    Console.WriteLine();
                    break;




            }

        }

    }
}