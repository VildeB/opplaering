using System;

namespace vinter
{
    class Program
    {
        static void Main(string[] args)
        {
            var antall = 10;
            var noe = true;
            for (int i = 0; i < antall; i++, noe = !noe)
            {
                if (noe)
                {
                    Console.WriteLine("Hilu Verden! {0}-{1} {2}",antall,i,noe);
                }
                else
                {
                    Console.WriteLine("Hello World! {0}-{1} {2}",antall,i,noe);
                }
                   
            }
        }
    }
}
