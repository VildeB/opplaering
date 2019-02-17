using System;

namespace helloconsole
{
    class Program
    {
        const string blå = "\u001b[34m";
        const string raud = "\u001b[14m";
        const string gul = "\u001b[33m";
        const string kvit = "\u001b[37m";
        const string reset= "\u001b[0m";

        static void Main(string[] args)
        {
            ConsoleTools.EnableAnsi();
            
            Console.WriteLine("Hello {0}World!",blå);
            
            Console.WriteLine("\u001b[0m");
        }
    }
}
