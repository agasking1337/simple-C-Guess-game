using System;
namespace MyAppsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess a number between 1 and 10!");
            Random rnd = new Random();
            int userNumber = 0;
            int newNumber = rnd.Next(1,10);

            int i = 0;
            while (userNumber != newNumber)
            {
                try
                {
                    userNumber = Convert.ToInt32(Console.ReadLine());
                    if (userNumber > newNumber)
                    {
                        Console.WriteLine($"{userNumber} is to high! Guess lower!");
                    }
                    else
                    {
                        Console.WriteLine($"{userNumber} is to low! Guess higher!");
                    }
                }
                catch 
                {
                    Console.WriteLine("Guess must be a number");
                    i--;
                }

                i++;
            }
            Console.WriteLine("Great! you guess right, it took you " + i + " times to guess the number! ");
            Console.ReadLine();
            
        }
    }
}
