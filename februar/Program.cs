using System;

namespace februar
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.A) 
            {
                Console.WriteLine("Du har trykket A");
            }
            else
            {
                Console.WriteLine("Du har ikke trykket A");
            }

       }
    }
}
