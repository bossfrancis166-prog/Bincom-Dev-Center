using System;

namespace Task4_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6, 8, 10 };

            // Sum of all elements
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            Console.WriteLine("Sum of array elements: " + sum);

            // Print each element
            Console.WriteLine("Array elements:");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }
    }
}