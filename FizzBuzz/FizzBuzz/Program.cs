using System;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzz.GetOutput(i));
            }
        }
    }
}