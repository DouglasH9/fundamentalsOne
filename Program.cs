using System;

namespace fundamentalsOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //     for (var i = 1; i <= 255; i++)
            //     {
            //         Console.WriteLine(i);
            //     }
            // for (int i = 1; i <= 100; i++)
            // {
            //     if (i % 15 != 0 && (i % 3 == 0 || i % 5 == 0))
            //     {
            //         Console.WriteLine(i);
            //     }
            // }
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else 
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
