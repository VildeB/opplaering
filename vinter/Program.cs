using System;

namespace vinter
{
    class Program
    {
        static void Main(string[] args)
        {
            //const string blå = "\u001b[34m";
            const string cyan = "\u001b[36m";
            const string raud = "\u001b[31m";
            // const string gul = "\u001b[33m";
            //const string kvit = "\u001b[37m";
            const string reset= "\u001b[0m";

            var antall = 10;
            var noe = true;

            ConsoleTools.EnableAnsi();
            for (int c = 0; c < antall; c++, noe = !noe)
            {
                for (int i = 0; i < antall; i++, noe = !noe)
                {
                    if (noe)
                    {
                        Console.Write("{0}aa",raud);
                    }
                    else
                    {
                        Console.Write("{0}bb",cyan);
                    }

                }
                Console.WriteLine();
            }
            
            Console.WriteLine(reset);
        }
    }
}

/*
       //    var ord =  Console.ReadLine();


               if (noe==true)
                {
                    Console.Write("{3}{4} {0}-{1} {2}",antall,i,noe,cyan,ord);
                }
                else
                {
                    Console.Write("{3}Hello World! {0}-{1} {2}",antall,i,noe,raud);
                }

 */