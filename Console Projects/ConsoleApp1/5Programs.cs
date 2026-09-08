using System;

namespace Task5_Greet
{
    class Program
    {
        static void Main(string[] args)
        {
            Greet("Alice");

            Console.ReadKey();
        }

        static void Greet(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}