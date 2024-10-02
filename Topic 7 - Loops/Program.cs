using System.Runtime.CompilerServices;

namespace Topic_7___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            
            int pin = (11111);
            int entry, guess;
            int randNum = generator.Next(1, 11);
            //Console.WriteLine("Welcome to the Bank");
            //Console.WriteLine("Please enter your PIN:");
            //int.TryParse(Console.ReadLine(), out entry);
            //while (entry != pin)
            //{
            //    Console.WriteLine("INCORRECT PIN TRY AGAIN");
            //    Console.WriteLine("PLEASE ENTER YOUR PIN:");
            //    int.TryParse(Console.ReadLine(), out entry);
            //    Console.WriteLine();

            //}
            //Console.WriteLine("PIN ACCEPTED");


            //While loops also check to see if something is true however they repeat if untrue


            Console.WriteLine("Please guess my secret random number from 1-10 or else");
            while (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.WriteLine("Invailid answer, try again");
            }
            while (guess != randNum)
            {
                Console.WriteLine("Incorect. Try again...");
            }
        }
    }
}
