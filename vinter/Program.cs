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
            const string uparrow = "\u001b[1A";
            const string downarrow = "\u001b[1B";
            const string rightarrow = "\u001b[1C";
            const string leftarrow = "\u001b[1D";

            
            ConsoleTools.EnableAnsi();
            Console.WriteLine ();
            for (var i = 0; i<25;i++) {
                Console.Write (uparrow);
            }
            for (var i = 0; i<25;i++) {
                Console.WriteLine ("                                                                                                                                 ");
            }
            ConsoleKeyInfo key;
            // ConsoleKey.DownArrow; ConsoleKey.UpArrow; ConsoleKey.LeftArrow; ConsoleKey.RightArrow
            var farge = 0;
            do {

                key=Console.ReadKey(true);
                
                if (
                    key.Key == ConsoleKey.DownArrow || 
                    key.Key == ConsoleKey.UpArrow || 
                    key.Key == ConsoleKey.LeftArrow || 
                    key.Key == ConsoleKey.RightArrow
                    ) 
                {
                        switch (key.Key) 
                        {
                            case ConsoleKey.DownArrow:
                                Console.Write (downarrow);
                                break;
                            case ConsoleKey.UpArrow:
                                Console.Write (uparrow);
                                break;
                            case ConsoleKey.RightArrow:
                                Console.Write (rightarrow);
                                break;
                            case ConsoleKey.LeftArrow:
                                Console.Write (leftarrow);
                                break;
                        }
                        farge = !farge;
                       /*  if (farge )
                        {
                            Console.Write (cyan);
                        }
                        else 
                        {
                            Console.Write (raud);
                        }
                        Console.Write ("*{0}",leftarrow);
                      
...
farge = (farge + 1) % 4;
…

switch (farge) {
case 0: ...
   break;
                    */
                }
             



            } while (key.Key != ConsoleKey.E);

            Console.WriteLine(reset);
        }
    }
}
