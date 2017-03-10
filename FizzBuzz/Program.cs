using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new Processor();
            for (var i = 1; i <= 100; i++)
            {
                Console.WriteLine(processor.GetValue(i));
            }

            Console.ReadLine();
        }
    }
}
