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


    }
}
