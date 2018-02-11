using System;

namespace first_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My first c sharp app!");
            counter();
        }

        static void counter() {
            for(int i = 1; i <= 255; i++) {
                if(i % 3 == 0) {
                    Console.WriteLine("Three {0}", i);
                } else if(i % 5 == 0) {
                    Console.WriteLine("Five {0}", i);
                }
            }
        }
    }
}
