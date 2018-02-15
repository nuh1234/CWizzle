using System;

namespace first_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard w = new Wizard("Harry Potter");
            Console.WriteLine("Name {0} Health {1} Intelligence {2}", w.name, w.health, w.intelligence);
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
