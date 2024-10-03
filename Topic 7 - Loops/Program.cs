using System.Runtime.CompilerServices;

namespace Topic_7___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            int pin = (11111);
            int entry, guess, dice1, dice2;
            int randNum = generator.Next(1, 11);
            string r;
            bool done = false;
            int tries = 0;
            //Console.WriteLine("Welcome to the Bank");
            //while (!done)
            //{

            //    Console.WriteLine("PLEASE ENTER YOUR PIN:");
            //    int.TryParse(Console.ReadLine(), out entry);
            //    Console.WriteLine();
            //    if (pin == entry)
            //    {
            //        Console.WriteLine("PIN ACCEPTED");
            //        done = true;
            //    }
            //    else if (tries == 5)
            //    {
            //        Console.WriteLine("To many tries. ACCESS DENIED");
            //        done = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("INCORRECT PIN TRY AGAIN");
            //        tries += 1;
            //    }


            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            //While loops also check to see if something is true however they repeat if untrue

            done = false;
            tries = 0;
            Console.WriteLine("Please guess my secret random number from 1-10 or else:");
            
            while (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.WriteLine("Invailid answer, try again");
                tries += 1;
            }
            while (guess != randNum)
            {
                if (guess > randNum)
                    Console.WriteLine("Lower");
                else if (guess < randNum)
                    Console.WriteLine("Higher");
                Console.WriteLine();
                Console.WriteLine("Incorect. Try again...");
                Console.WriteLine();
                Console.WriteLine("Please guess my secret random number from 1-10 or else:");
                while (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Invailid answer, try again");
                }

            }
            Console.WriteLine("That is correct");


            Console.WriteLine("Press 'R' to roll the dice:");
            r = Console.ReadLine().ToLower();
            while (r == "r")
            {
                dice1 = generator.Next(1, 7);
                dice2 = generator.Next(1, 7);
                if (dice1 == dice2)
                {
                    
                    Console.WriteLine("You rolled a " + dice1 + " and a " + dice2);
                    Console.WriteLine("You rolled doubles!");
                    Console.WriteLine("Press 'R' to roll again:");
                    r = Console.ReadLine().ToLower();
                }
                else if (dice1 != dice2)
                {
                    Console.WriteLine("You rolled a " + dice1 + " and a " + dice2);
                    Console.WriteLine("Press 'R' to roll again:");
                    r = Console.ReadLine().ToLower();
                }
                    

            }
            Console.WriteLine("OK, no rolling for you...");



        }
    }
}

